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
    public partial class PublishPost : Form
    {
        public PublishPost()
        {
            InitializeComponent();
        }

        private void Pubilshthepost_Click(object sender, EventArgs e)
        {   
            string posttitle = publishtitle.Text.Trim();
            string postmain = publishmain.Text.Trim();
            if (posttitle == "" || postmain == "")
                MessageBox.Show("标题或内容不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                string LV = LVOfPost.Text.Trim();
                string pid = "select MAX(PID) from POST";
                DB.SQLHelper selectpid = new DB.SQLHelper();
                SqlDataReader readpid = selectpid.read(pid);
                readpid.Read();
                DB.UserData.PublicValue.PID = Convert.ToInt32(readpid[0]) + 1; //全局变量，将pid查询结果用read读出后再用Convert.ToInt32转换为int

                string insert = "insert into POST(UID,PID,PDATE,TITLE,PTEXT,LV) values ('" + DB.UserData.PublicValue.UserID + "'," + DB.UserData.PublicValue.PID + ",'" + time + "','" + posttitle + "','" + postmain + "','" + LV + "')";
                try
                {
                    DB.SQLHelper sqlHelper = new DB.SQLHelper();
                    int n = sqlHelper.Execute(insert);
                    if (n > 0)
                    {

                        MessageBox.Show("发表成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                        MessageBox.Show("因未知原因发表失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void Chongzhi_Click(object sender, EventArgs e)
        {
            publishtitle.Text ="";
            publishmain.Text ="";
        }

        private void PublishPost_Load(object sender, EventArgs e)
        {
            LVOfPost.SelectedIndex = 0;
        }
    }
}
