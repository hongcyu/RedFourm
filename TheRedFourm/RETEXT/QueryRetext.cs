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
    public partial class QueryRetext : Form
    {
        public QueryRetext()
        {
            InitializeComponent();
        }

        private void QueryRetext_Load(object sender, EventArgs e)
        {
            queryofretext.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Queryretextbutton_Click(object sender, EventArgs e)
        {
            string RUID = uidofretext.Text.Trim();
            string Rtime = timeofretext.Text.Trim();
            if (RUID == "" && Rtime == "")
                MessageBox.Show("你必须输入一个查询约束条件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {


                try
                {
                    string sqlquery = "select UID as 用户ID ,PID as 帖子ID,REDATE as 回复日期,RETEXT as 内容,FLR as 楼层数 from RETEXT where UID='" + RUID + "' ";
                    if (Rtime.Length > 0)
                        sqlquery += " and REDATE='" + Rtime + "'";
                    DB.SQLHelper Queryretext = new DB.SQLHelper();
                    DataSet ds = Queryretext.GetDataSet(sqlquery);
                    DataTable dt = ds.Tables[0];
                    queryofretext.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        queryofretext.ContextMenuStrip = null;//删除菜单在无数据时不显示
                        MessageBox.Show("没有符合条件的帖子记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        queryofretext.ContextMenuStrip = contextMenuStripofretext;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DateTimePickerofretext_ValueChanged(object sender, EventArgs e)//时间设置
        {
            timeofretext.Text = dateTimePickerofretext.Text;

        }

        private void LookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ViewThisPID = queryofretext.SelectedRows[0].Cells["帖子ID"].Value.ToString();
            DB.UserData.PublicValue.viewPID = Convert.ToInt32(ViewThisPID);
            RETEXT.PublishRetext form = new RETEXT.PublishRetext();
            form.Show();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteoftype = "select TYPE from UI where UID='" + DB.UserData.PublicValue.UserID + "'";
                string strFLR = queryofretext.SelectedRows[0].Cells["楼层数"].Value.ToString();
                string deleteofuid = "select UID from RETEXT where PID=" + DB.UserData.PublicValue.viewPID + " AND FLR='" + strFLR + "'";
                DB.SQLHelper delete = new DB.SQLHelper();
                SqlDataReader readuid = delete.read(deleteofuid);
                readuid.Read();

                DialogResult dialogResult = MessageBox.Show("你确定要删除" + strFLR + "楼的回复吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)//选择NO则不进行下一步
                    return;

                if (deleteoftype == "1" || readuid[0].ToString() == DB.UserData.PublicValue.UserID )//判断，若为管理员或回复者则可以删除回复
                {
                    string deleteRetext = "delete from RETEXT where PID=" + DB.UserData.PublicValue.viewPID + " and FLR='" + strFLR + "'";
                    DB.SQLHelper sqlhelp = new DB.SQLHelper();
                    sqlhelp.OperateTb(deleteRetext);
                   Queryretextbutton_Click(null, null);


                }
                else
                MessageBox.Show("你不是回复用户或管理员，不能删除该回复！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Chongzhi_Click(object sender, EventArgs e)
        {
            uidofretext.Text = "";
            timeofretext.Text = "";
        }
    }
}
