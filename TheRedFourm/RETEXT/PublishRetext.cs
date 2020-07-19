using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TheRedFourm.RETEXT
{
    public partial class PublishRetext : Form
    {
        public PublishRetext()
        {
            InitializeComponent();
        }

        private void PublishRetext_Load(object sender, EventArgs e)
        {
            dataGridViewofretext.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showPID.Text = DB.UserData.PublicValue.viewPID.ToString();


            try {//进行评论的加载
                string sqlofretext = "select UID as 用户ID ,REDATE as 回复日期,RETEXT as 内容,FLR as 楼层数 from RETEXT where PID=" + DB.UserData.PublicValue.viewPID + "";
                sqlofretext += " order by  FLR";
                DB.SQLHelper Queryretext = new DB.SQLHelper();
                DataSet ds = Queryretext.GetDataSet(sqlofretext);
                DataTable dt = ds.Tables[0];
                dataGridViewofretext.DataSource = dt;
                if (dt.Rows.Count == 0)
                    dataGridViewofretext.ContextMenuStrip = null;
                else
                    dataGridViewofretext.ContextMenuStrip = contextMenuStripofretext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try {
                string title = "select TITLE from POST where PID="+DB.UserData.PublicValue.viewPID+"";
                string main = "select PTEXT from POST where PID=" + DB.UserData.PublicValue.viewPID + "";
                DB.SQLHelper showpost = new DB.SQLHelper();
                SqlDataReader readtitle = showpost.read(title);
                SqlDataReader readmain = showpost.read(main);
                readtitle.Read();
                readmain.Read();
                titletext.Text = readtitle[0].ToString().Trim();
                maintext.Text = readmain[0].ToString().Trim();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Retext1_Click(object sender, EventArgs e)
        {

            try
            {
                string retext = retextbox.Text.Trim();
                if (retext == "")
                    MessageBox.Show("回复不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DB.SQLHelper selectflr = new DB.SQLHelper();
                    string time = DateTime.Now.ToString("yyyy/MM/dd");
                    string FLRinPost = "select MAX(FLR) from RETEXT where PID=" + DB.UserData.PublicValue.viewPID + "";
                    
                    SqlDataReader readflr = selectflr.read(FLRinPost);
                    readflr.Read();
                    DB.UserData.PublicValue.FLR = readflr[0]==DBNull.Value?1:(Convert.ToInt32(readflr[0]) + 1); //判断是不是为空，全局变量，将flr查询结果用read读出后再用Convert.ToInt32转换为int

                    string sqlretext = "insert into RETEXT(UID,PID,REDATE,RETEXT,FLR) values ('" + DB.UserData.PublicValue.UserID + "'," + DB.UserData.PublicValue.viewPID + ",'" + time + "','" + retext + "'," + DB.UserData.PublicValue.FLR + ")";
                    DB.SQLHelper Insert = new DB.SQLHelper();
                    int n = Insert.Execute(sqlretext);
                    //返回用户创建结果
                    if (n > 0)
                    {
                        MessageBox.Show("回复成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PublishRetext_Load(null, null);
                    }
                    else
                        MessageBox.Show("回复失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Deldeteretext_Click(object sender, EventArgs e)//删除菜单
        {
            try
            {
                string deleteoftype = "select TYPE from UI where UID='"+DB.UserData.PublicValue.UserID+"'";
                string strFLR = dataGridViewofretext.SelectedRows[0].Cells["楼层数"].Value.ToString();
                string deleteofuid = "select UID from RETEXT where PID=" + DB.UserData.PublicValue.viewPID + " AND FLR='" + strFLR + "'";
                string louzhuuid = "select UID from POST where PID=" + DB.UserData.PublicValue.viewPID + "";
                DB.SQLHelper delete = new DB.SQLHelper();
                SqlDataReader readuid = delete.read(deleteofuid);
                SqlDataReader readlouzhuuid = delete.read(louzhuuid);
                readuid.Read();
                readlouzhuuid.Read();

                DialogResult dialogResult = MessageBox.Show("你确定要删除" + strFLR + "楼的回复吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)//选择NO则不进行下一步
                    return;

                if (deleteoftype == "1" || readuid[0].ToString() == DB.UserData.PublicValue.UserID || readlouzhuuid[0].ToString() == DB.UserData.PublicValue.UserID)//判断，若为管理员或回复者或帖子拥有者则可以删除回复
                {
                    string deleteFLR = "delete from RETEXT where PID=" + DB.UserData.PublicValue.viewPID + " and FLR='" + strFLR + "'";
                    try
                    {
                        DB.SQLHelper sqlhelp = new DB.SQLHelper();
                        sqlhelp.OperateTb(deleteFLR);
                        PublishRetext_Load(null, null);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("你不是回复用户或管理员，不能删除该回复！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }
    }
    }

