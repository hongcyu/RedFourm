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

namespace TheRedFourm.PostSystem
{
    public partial class QueryPost : Form
    {
        public QueryPost()
        {
            InitializeComponent();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            dataGridViewpost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  //整行选中
        }

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            time.Text=dateTime.Text;
        }

        private void Qpost_Click(object sender, EventArgs e)
        {
            string Quid = QueryUID.Text.Trim();//查询的文本内容
            string Qpid = QueryPID.Text.Trim();
            string Qtime = time.Text.Trim();
           
            if (Quid == "" && Qpid == "" && Qtime == "")
            MessageBox.Show("你必须输入一个查询约束条件","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


            else {

                try {
                    if (Qpid.Length == 0 && Quid.Length == 0)
                    {
                        string sql = "select UID as 用户ID ,PID as 帖子ID,PDATE as 发帖日期,TITLE as 标题,PTEXT as 内容,LV as 等级 from POST where PDATE between '"+Qtime+ " 00:00:00' and '" + Qtime + " 23:59:59'";
                        sql += " order by  PDATE";
                        DB.SQLHelper Querypost = new DB.SQLHelper();
                        DataSet ds = Querypost.GetDataSet(sql);
                        DataTable dt = ds.Tables[0];
                        dataGridViewpost.DataSource = dt;
                        if (dt.Rows.Count == 0)
                            MessageBox.Show("没有符合条件的帖子记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (Quid.Length == 0)
                    {
                        time.Text = "";
                        string sql = "select UID as 用户ID ,PID as 帖子ID,PDATE as 发帖日期,TITLE as 标题,PTEXT as 内容,LV as 等级 from POST where PID='" + Qpid + "' ";
                        sql += " order by  PDATE";
                        DB.SQLHelper Querypost = new DB.SQLHelper();
                        DataSet ds = Querypost.GetDataSet(sql);
                        DataTable dt = ds.Tables[0];
                        dataGridViewpost.DataSource = dt;
                        if (dt.Rows.Count == 0)
                            MessageBox.Show("没有符合条件的帖子记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        string sql = "select UID as 用户ID ,PID as 帖子ID,PDATE as 发帖日期,TITLE as 标题,PTEXT as 内容,LV as 等级 from POST where UID='" + Quid + "' ";
                        if (Qpid.Length > 0)
                            sql += " and PID='" + Qpid + "' ";
                        if (Qtime.Length > 0)
                            sql += " and PDATE BETWEEN  '" + Qtime + " 00:00:00' and '" + Qtime + " 23:59:59' ";
                        sql += " order by  PDATE";
                        DB.SQLHelper Querypost = new DB.SQLHelper();
                        DataSet ds = Querypost.GetDataSet(sql);
                        DataTable dt = ds.Tables[0];
                        dataGridViewpost.DataSource = dt;
                        if (dt.Rows.Count == 0)
                        {
                            dataGridViewpost.ContextMenuStrip = null;//删除菜单在无数据时不显示
                            MessageBox.Show("没有符合条件的帖子记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            dataGridViewpost.ContextMenuStrip = deleteMenuStrip;
                    }  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e) //删除菜单
        {
           

            string deleteoftype = "select TYPE from UI where UID='" + DB.UserData.PublicValue.UserID + "'";

            string strPID = dataGridViewpost.SelectedRows[0].Cells["帖子ID"].Value.ToString();//捕捉选中的单元格

            string deleteofuid = "select UID from POST where PID='" + strPID + "'";
            DB.SQLHelper delete = new DB.SQLHelper();
            SqlDataReader readuid = delete.read(deleteofuid);
            readuid.Read();

            DialogResult dialogResult = MessageBox.Show("你确定要删除帖子ID为：" + strPID + "的帖子信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)//选择NO则不进行下一步
                return;

            if (deleteoftype=="1" || readuid[0].ToString()==DB.UserData.PublicValue.UserID)
            {
                string strdelete = "Delete From POST Where PID='" + strPID + "'";
                try
                {
                    DB.SQLHelper sqlhelp = new DB.SQLHelper();
                    sqlhelp.OperateTb(strdelete);
                    Qpost_Click(null, null);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("你不是发帖用户或管理员，不能删除该帖子！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }

        private void Chongzhipost_Click(object sender, EventArgs e)
        {
            QueryUID.Text="";        //重置查询的文本内容
            QueryPID.Text="";
            time.Text="";
        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ViewThisPID = dataGridViewpost.SelectedRows[0].Cells["帖子ID"].Value.ToString();
            DB.UserData.PublicValue.viewPID = Convert.ToInt32(ViewThisPID);
            RETEXT.PublishRetext form = new RETEXT.PublishRetext();
            form.Show();
        }
    }
}
