namespace TheRedFourm.PostSystem
{
    partial class PublishPost
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publishtitle = new System.Windows.Forms.TextBox();
            this.publishmain = new System.Windows.Forms.TextBox();
            this.pubilshthepost = new System.Windows.Forms.Button();
            this.chongzhi = new System.Windows.Forms.Button();
            this.postLV = new System.Windows.Forms.Label();
            this.LVOfPost = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(72, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(72, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "内容：";
            // 
            // publishtitle
            // 
            this.publishtitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publishtitle.Location = new System.Drawing.Point(150, 44);
            this.publishtitle.MaxLength = 50;
            this.publishtitle.Multiline = true;
            this.publishtitle.Name = "publishtitle";
            this.publishtitle.Size = new System.Drawing.Size(654, 26);
            this.publishtitle.TabIndex = 1;
            // 
            // publishmain
            // 
            this.publishmain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publishmain.Location = new System.Drawing.Point(150, 100);
            this.publishmain.MaxLength = 500;
            this.publishmain.Multiline = true;
            this.publishmain.Name = "publishmain";
            this.publishmain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.publishmain.Size = new System.Drawing.Size(654, 382);
            this.publishmain.TabIndex = 1;
            // 
            // pubilshthepost
            // 
            this.pubilshthepost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pubilshthepost.Location = new System.Drawing.Point(280, 541);
            this.pubilshthepost.Name = "pubilshthepost";
            this.pubilshthepost.Size = new System.Drawing.Size(147, 61);
            this.pubilshthepost.TabIndex = 2;
            this.pubilshthepost.Text = "发布";
            this.pubilshthepost.UseVisualStyleBackColor = true;
            this.pubilshthepost.Click += new System.EventHandler(this.Pubilshthepost_Click);
            // 
            // chongzhi
            // 
            this.chongzhi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chongzhi.Location = new System.Drawing.Point(524, 541);
            this.chongzhi.Name = "chongzhi";
            this.chongzhi.Size = new System.Drawing.Size(147, 61);
            this.chongzhi.TabIndex = 2;
            this.chongzhi.Text = "重置";
            this.chongzhi.UseVisualStyleBackColor = true;
            this.chongzhi.Click += new System.EventHandler(this.Chongzhi_Click);
            // 
            // postLV
            // 
            this.postLV.AutoSize = true;
            this.postLV.BackColor = System.Drawing.Color.Transparent;
            this.postLV.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.postLV.Location = new System.Drawing.Point(72, 498);
            this.postLV.Name = "postLV";
            this.postLV.Size = new System.Drawing.Size(55, 25);
            this.postLV.TabIndex = 3;
            this.postLV.Text = "等级:";
            // 
            // LVOfPost
            // 
            this.LVOfPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LVOfPost.FormattingEnabled = true;
            this.LVOfPost.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.LVOfPost.Location = new System.Drawing.Point(150, 505);
            this.LVOfPost.Name = "LVOfPost";
            this.LVOfPost.Size = new System.Drawing.Size(94, 20);
            this.LVOfPost.TabIndex = 4;
            // 
            // PublishPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheRedFourm.Properties.Resources._006z09Zkgy1fm5xg9dvdfj30m80vg78x;
            this.ClientSize = new System.Drawing.Size(933, 643);
            this.Controls.Add(this.LVOfPost);
            this.Controls.Add(this.postLV);
            this.Controls.Add(this.chongzhi);
            this.Controls.Add(this.pubilshthepost);
            this.Controls.Add(this.publishmain);
            this.Controls.Add(this.publishtitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PublishPost";
            this.Text = "发表帖子";
            this.Load += new System.EventHandler(this.PublishPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox publishtitle;
        private System.Windows.Forms.TextBox publishmain;
        private System.Windows.Forms.Button pubilshthepost;
        private System.Windows.Forms.Button chongzhi;
        private System.Windows.Forms.Label postLV;
        private System.Windows.Forms.ComboBox LVOfPost;
    }
}