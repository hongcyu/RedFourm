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
    public partial class WindowsOfUser : Form
    {
        public WindowsOfUser()
        {
            InitializeComponent();
        }



        private void PersionData_Click(object sender, EventArgs e)
        {
            PersionData Form3 = new PersionData();
            Form3.Show();
        }

        private void WindowsOfUser_Load(object sender, EventArgs e)
        {
            labelname.Text = DB.UserData.PublicValue.UserName;
        }

        private void Guanbi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UPublishPost_Click(object sender, EventArgs e)
        {
            PostSystem.PublishPost formpost = new PostSystem.PublishPost();
            formpost.Show();
        }

        private void UQueryPost_Click(object sender, EventArgs e)
        {
            PostSystem.QueryPost formpsot = new PostSystem.QueryPost();
            formpsot.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LoginSystem.LoginSys Form2 = new LoginSystem.LoginSys();
            Form2.Show();
            this.Close();
        }

        private void UQueryRetext_Click(object sender, EventArgs e)
        {
            RETEXT.QueryRetext form3 = new RETEXT.QueryRetext();
            form3.Show();
            
        }
    }
}
