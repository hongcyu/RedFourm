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
    
    public partial class LoginSys : Form
        {
        public string UserID { get; private set; }

        public LoginSys()
        {           InitializeComponent();
        }
        
            private void Loginin_Click(object sender, EventArgs e)
        {      
                string userUID = this.txtUserName.Text.Trim();
                string userPassword = this.txtPassword.Text.Trim();
                
                // 验证数据
                // 验证用户输入是否为空，若为空，提示用户信息

                if (userUID.Equals("") || userPassword.Equals(""))

                {
                    MessageBox.Show("用户名或密码不能为空！");
                }
                // 若不为空，验证用户名和密码是否与数据库匹配

                // 这里只做字符串对比验证
                else

                {
                //用户名和密码验证正确，提示成功，并执行跳转界面。
                try
                {
                    string User = "select UID from UI where UID='" + userUID + "' And PASSWORD='"+userPassword+"'";
                    string userName = "SELECT NAME from UI where UID='" + userUID + "'";
                    string userSex = "SELECT SEX from UI where UID='" + userUID + "'";
                    string userAge = "SELECT AGE from UI where UID='" + userUID + "'";
                    string userOcc = "SELECT OCC from UI where UID='" + userUID + "'";
                    string userHob = "SELECT HOB from UI where UID='" + userUID + "'";
                    DB.SQLHelper loginthesystem = new DB.SQLHelper();
                    SqlDataReader read1 = loginthesystem.read(User);
                    SqlDataReader readname = loginthesystem.read(userName);
                    SqlDataReader readsex = loginthesystem.read(userSex);
                    SqlDataReader readage = loginthesystem.read(userAge);
                    SqlDataReader readocc = loginthesystem.read(userOcc);
                    SqlDataReader readhob = loginthesystem.read(userHob);

                    if (read1.Read())
                    {
                        MessageBox.Show("登录成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DB.UserData.PublicValue.UserID = userUID;
                        DB.UserData.PublicValue.UserPassword = userPassword;

                        readname.Read();
                        DB.UserData.PublicValue.UserName = readname[0].ToString();//将名字存入全局变量
                        readsex.Read();
                        DB.UserData.PublicValue.UserSex = readsex[0].ToString();//将性别存入全局变量
                        readage.Read();
                        DB.UserData.PublicValue.UserAge = readage[0].ToString();//将年龄存入全局变量
                        readocc.Read();
                        DB.UserData.PublicValue.UserOcc = readocc[0].ToString();//将职业存入全局变量
                        readhob.Read();
                        DB.UserData.PublicValue.UserHob = readhob[0].ToString();//将爱好存入全局变量

                        MainSystem.WindowsOfUser From2 = new MainSystem.WindowsOfUser();
                        From2.Show();
                        this.Hide();

                    }

                    //用户名和密码验证错误，提示错误。

                    else

                    {
                        MessageBox.Show("用户名或密码错误！","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                   
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterSys Form1 = new RegisterSys();
            Form1.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginSys_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
