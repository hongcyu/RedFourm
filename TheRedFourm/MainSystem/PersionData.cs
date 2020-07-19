using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRedFourm.MainSystem
{
    public partial class PersionData : Form
    {
        public PersionData()
        {
            InitializeComponent();
        }

        private void PersionData_Load(object sender, EventArgs e)
        {
            labelUID.Text = DB.UserData.PublicValue.UserID.ToString();   //查询用户信息并填入文本框
            textBoxPASSWORD.Text = DB.UserData.PublicValue.UserPassword.Trim();
            textBoxNAME.Text = DB.UserData.PublicValue.UserName.Trim();
            comboBoxSEX.Text = DB.UserData.PublicValue.UserSex;
            textBoxAGE.Text = DB.UserData.PublicValue.UserAge.Trim();
            textBoxOCC.Text = DB.UserData.PublicValue.UserOcc.Trim();
            textBoxHOB.Text = DB.UserData.PublicValue.UserHob.Trim();
        }

        private void ChangeData_Click(object sender, EventArgs e)
        {   if (  textBoxNAME.Text==""||textBoxPASSWORD.Text == "" || textBoxAGE.Text == "" || textBoxOCC.Text == "" || textBoxHOB.Text == "")
                MessageBox.Show("请把所有为空的项目填写完整", "提示");
            else
            {
                string updatepasswoad = "update UI set PASSWORD='" + textBoxPASSWORD.Text.ToString() + "' where UID='" + DB.UserData.PublicValue.UserID + "'";
                string updatename = "update UI set NAME='" + textBoxNAME.Text.ToString() + "' where UID='" + DB.UserData.PublicValue.UserID + "'";
                string updatesex = "update UI set SEX='" + comboBoxSEX.Text.ToString() + "' where UID='" + DB.UserData.PublicValue.UserID + "'";
                string updateage = "update UI set AGE='" + textBoxAGE.Text.ToString() + "' where UID='" + DB.UserData.PublicValue.UserID + "'";
                string updateocc = "update UI set OCC='" + textBoxOCC.Text.ToString() + "' where UID='" + DB.UserData.PublicValue.UserID + "'";
                string updatehob = "update UI set HOB='" + textBoxHOB.Text.ToString() + "' where UID='" + DB.UserData.PublicValue.UserID + "'";


                DB.UserData.PublicValue.UserPassword = textBoxPASSWORD.Text.ToString();   //更新全局变量
                DB.UserData.PublicValue.UserName = textBoxNAME.Text.ToString();
                DB.UserData.PublicValue.UserSex = comboBoxSEX.Text;
                DB.UserData.PublicValue.UserAge = textBoxAGE.Text.ToString();
                DB.UserData.PublicValue.UserOcc = textBoxOCC.Text.ToString();
                DB.UserData.PublicValue.UserHob = textBoxHOB.Text.ToString();

                DB.SQLHelper update = new DB.SQLHelper();
                int num = update.Execute(updatepasswoad) + update.Execute(updatename) + update.Execute(updatesex) + update.Execute(updateage) + update.Execute(updateocc) + update.Execute(updatehob);
                if (num > 5)
                {   
                    MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("更新失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
