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
namespace TheRedFourm.LoginSystem
{
    public partial class RegisterSys : Form
    {
        public RegisterSys()
        {
            InitializeComponent();
        }

        private void LoginSys_Load(object sender, EventArgs e)
        {

        }

        private void Reg_Click(object sender, EventArgs e)
        {
            string strUID = textBoxUID.Text.Trim();
            string strPWD = textBoxPASSWORD.Text.Trim();
            string strNAME = textBoxNAME.Text.Trim();
            string strSEX = comboBoxSEX.Text;
            string strAGE = textBoxAGE.Text.Trim();
            string strOCC = textBoxOCC.Text.Trim();
            string strHOB = textBoxHOB.Text.Trim();

            //创建命令向数据库插入数据
            if(strUID==""||strPWD==""||strNAME==""||strSEX==""||strAGE==""||strOCC==""||strHOB=="")
                {
                MessageBox.Show("注册失败！请将信息填写完整！","提示");
            }
            else {
                string name = "select UID from UI where UID='" + strUID + "'";
                DB.SQLHelper select = new DB.SQLHelper();
                SqlDataReader read = select.read(name);
                    if(read.Read())
                {
                    MessageBox.Show("注册失败！UID已存在！","提示");
                }
                else {
                    DB.SQLHelper Insert = new DB.SQLHelper();
                    string strInsert = "Insert into UI (UID,PASSWORD,NAME,SEX,AGE,OCC,HOB) Values('" + strUID + "','" + strPWD + "','" + strNAME + "','" + strSEX + "','" + strAGE + "','" + strOCC + "','" + strHOB + "')";
                    int n = Insert.Execute(strInsert);
                    //返回用户创建结果
                    if (n > 0)
                    {
                        MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                        this.Close();
                    }
                    else
                        MessageBox.Show("注册失败！" ,"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
