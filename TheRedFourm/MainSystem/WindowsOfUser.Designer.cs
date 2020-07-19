namespace TheRedFourm.MainSystem
{
    partial class WindowsOfUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UQueryPost = new System.Windows.Forms.Button();
            this.UPublishPost = new System.Windows.Forms.Button();
            this.UQueryRetext = new System.Windows.Forms.Button();
            this.PersionData = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guanbi = new System.Windows.Forms.Button();
            this.Cancellation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UQueryPost
            // 
            this.UQueryPost.Location = new System.Drawing.Point(283, 290);
            this.UQueryPost.Name = "UQueryPost";
            this.UQueryPost.Size = new System.Drawing.Size(122, 58);
            this.UQueryPost.TabIndex = 1;
            this.UQueryPost.Text = "查询帖子";
            this.UQueryPost.UseVisualStyleBackColor = true;
            this.UQueryPost.Click += new System.EventHandler(this.UQueryPost_Click);
            // 
            // UPublishPost
            // 
            this.UPublishPost.Location = new System.Drawing.Point(53, 290);
            this.UPublishPost.Name = "UPublishPost";
            this.UPublishPost.Size = new System.Drawing.Size(122, 58);
            this.UPublishPost.TabIndex = 0;
            this.UPublishPost.Text = "发布帖子";
            this.UPublishPost.UseVisualStyleBackColor = true;
            this.UPublishPost.Click += new System.EventHandler(this.UPublishPost_Click);
            // 
            // UQueryRetext
            // 
            this.UQueryRetext.Location = new System.Drawing.Point(506, 290);
            this.UQueryRetext.Name = "UQueryRetext";
            this.UQueryRetext.Size = new System.Drawing.Size(122, 58);
            this.UQueryRetext.TabIndex = 3;
            this.UQueryRetext.Text = "查询回复";
            this.UQueryRetext.UseVisualStyleBackColor = true;
            this.UQueryRetext.Click += new System.EventHandler(this.UQueryRetext_Click);
            // 
            // PersionData
            // 
            this.PersionData.Location = new System.Drawing.Point(463, 12);
            this.PersionData.Name = "PersionData";
            this.PersionData.Size = new System.Drawing.Size(78, 29);
            this.PersionData.TabIndex = 4;
            this.PersionData.Text = "个人资料";
            this.PersionData.UseVisualStyleBackColor = true;
            this.PersionData.Click += new System.EventHandler(this.PersionData_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(279, 16);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(47, 20);
            this.labelname.TabIndex = 8;
            this.labelname.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(222, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "欢迎：";
            // 
            // guanbi
            // 
            this.guanbi.Location = new System.Drawing.Point(627, 12);
            this.guanbi.Name = "guanbi";
            this.guanbi.Size = new System.Drawing.Size(51, 29);
            this.guanbi.TabIndex = 6;
            this.guanbi.Text = "关闭";
            this.guanbi.UseVisualStyleBackColor = true;
            this.guanbi.Click += new System.EventHandler(this.Guanbi_Click);
            // 
            // Cancellation
            // 
            this.Cancellation.Location = new System.Drawing.Point(559, 12);
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.Size = new System.Drawing.Size(51, 29);
            this.Cancellation.TabIndex = 5;
            this.Cancellation.Text = "注销";
            this.Cancellation.UseVisualStyleBackColor = true;
            this.Cancellation.Click += new System.EventHandler(this.Button5_Click);
            // 
            // WindowsOfUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheRedFourm.Properties.Resources._006z09Zkgy1fm5xg9dvdfj30m80vg78x;
            this.ClientSize = new System.Drawing.Size(690, 488);
            this.Controls.Add(this.guanbi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.PersionData);
            this.Controls.Add(this.Cancellation);
            this.Controls.Add(this.UQueryRetext);
            this.Controls.Add(this.UPublishPost);
            this.Controls.Add(this.UQueryPost);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WindowsOfUser";
            this.Text = "论坛管理界面";
            this.Load += new System.EventHandler(this.WindowsOfUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UQueryPost;
        private System.Windows.Forms.Button UPublishPost;
        private System.Windows.Forms.Button UQueryRetext;
        private System.Windows.Forms.Button PersionData;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guanbi;
        private System.Windows.Forms.Button Cancellation;
    }
}