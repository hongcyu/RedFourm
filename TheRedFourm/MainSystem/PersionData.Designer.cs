namespace TheRedFourm.MainSystem
{
    partial class PersionData
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
            this.comboBoxSEX = new System.Windows.Forms.ComboBox();
            this.textBoxHOB = new System.Windows.Forms.TextBox();
            this.textBoxOCC = new System.Windows.Forms.TextBox();
            this.textBoxAGE = new System.Windows.Forms.TextBox();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.RegHOB = new System.Windows.Forms.Label();
            this.RegOCC = new System.Windows.Forms.Label();
            this.RegAGE = new System.Windows.Forms.Label();
            this.RegSEX = new System.Windows.Forms.Label();
            this.RegNAME = new System.Windows.Forms.Label();
            this.RegPASSWORD = new System.Windows.Forms.Label();
            this.RegUID = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.ChangeData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSEX
            // 
            this.comboBoxSEX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSEX.FormattingEnabled = true;
            this.comboBoxSEX.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSEX.Location = new System.Drawing.Point(136, 157);
            this.comboBoxSEX.Name = "comboBoxSEX";
            this.comboBoxSEX.Size = new System.Drawing.Size(100, 20);
            this.comboBoxSEX.TabIndex = 18;
            // 
            // textBoxHOB
            // 
            this.textBoxHOB.Location = new System.Drawing.Point(136, 251);
            this.textBoxHOB.Name = "textBoxHOB";
            this.textBoxHOB.Size = new System.Drawing.Size(100, 21);
            this.textBoxHOB.TabIndex = 21;
            // 
            // textBoxOCC
            // 
            this.textBoxOCC.Location = new System.Drawing.Point(136, 218);
            this.textBoxOCC.Name = "textBoxOCC";
            this.textBoxOCC.Size = new System.Drawing.Size(100, 21);
            this.textBoxOCC.TabIndex = 20;
            // 
            // textBoxAGE
            // 
            this.textBoxAGE.Location = new System.Drawing.Point(136, 188);
            this.textBoxAGE.MaxLength = 3;
            this.textBoxAGE.Name = "textBoxAGE";
            this.textBoxAGE.Size = new System.Drawing.Size(100, 21);
            this.textBoxAGE.TabIndex = 19;
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(136, 126);
            this.textBoxNAME.MaxLength = 10;
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.Size = new System.Drawing.Size(100, 21);
            this.textBoxNAME.TabIndex = 17;
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(136, 96);
            this.textBoxPASSWORD.MaxLength = 16;
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.Size = new System.Drawing.Size(100, 21);
            this.textBoxPASSWORD.TabIndex = 16;
            this.textBoxPASSWORD.UseSystemPasswordChar = true;
            // 
            // RegHOB
            // 
            this.RegHOB.AutoSize = true;
            this.RegHOB.BackColor = System.Drawing.Color.Transparent;
            this.RegHOB.Location = new System.Drawing.Point(91, 251);
            this.RegHOB.Name = "RegHOB";
            this.RegHOB.Size = new System.Drawing.Size(41, 12);
            this.RegHOB.TabIndex = 28;
            this.RegHOB.Text = "爱好：";
            // 
            // RegOCC
            // 
            this.RegOCC.AutoSize = true;
            this.RegOCC.BackColor = System.Drawing.Color.Transparent;
            this.RegOCC.Location = new System.Drawing.Point(91, 218);
            this.RegOCC.Name = "RegOCC";
            this.RegOCC.Size = new System.Drawing.Size(41, 12);
            this.RegOCC.TabIndex = 27;
            this.RegOCC.Text = "职业：";
            // 
            // RegAGE
            // 
            this.RegAGE.AutoSize = true;
            this.RegAGE.BackColor = System.Drawing.Color.Transparent;
            this.RegAGE.Location = new System.Drawing.Point(91, 188);
            this.RegAGE.Name = "RegAGE";
            this.RegAGE.Size = new System.Drawing.Size(41, 12);
            this.RegAGE.TabIndex = 26;
            this.RegAGE.Text = "年龄：";
            // 
            // RegSEX
            // 
            this.RegSEX.AutoSize = true;
            this.RegSEX.BackColor = System.Drawing.Color.Transparent;
            this.RegSEX.Location = new System.Drawing.Point(91, 157);
            this.RegSEX.Name = "RegSEX";
            this.RegSEX.Size = new System.Drawing.Size(41, 12);
            this.RegSEX.TabIndex = 25;
            this.RegSEX.Text = "性别：";
            // 
            // RegNAME
            // 
            this.RegNAME.AutoSize = true;
            this.RegNAME.BackColor = System.Drawing.Color.Transparent;
            this.RegNAME.Location = new System.Drawing.Point(91, 126);
            this.RegNAME.Name = "RegNAME";
            this.RegNAME.Size = new System.Drawing.Size(41, 12);
            this.RegNAME.TabIndex = 24;
            this.RegNAME.Text = "昵称：";
            // 
            // RegPASSWORD
            // 
            this.RegPASSWORD.AutoSize = true;
            this.RegPASSWORD.BackColor = System.Drawing.Color.Transparent;
            this.RegPASSWORD.Location = new System.Drawing.Point(91, 96);
            this.RegPASSWORD.Name = "RegPASSWORD";
            this.RegPASSWORD.Size = new System.Drawing.Size(35, 12);
            this.RegPASSWORD.TabIndex = 23;
            this.RegPASSWORD.Text = "密码:";
            // 
            // RegUID
            // 
            this.RegUID.AutoSize = true;
            this.RegUID.BackColor = System.Drawing.Color.Transparent;
            this.RegUID.Location = new System.Drawing.Point(91, 71);
            this.RegUID.Name = "RegUID";
            this.RegUID.Size = new System.Drawing.Size(29, 12);
            this.RegUID.TabIndex = 22;
            this.RegUID.Text = "UID:";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.BackColor = System.Drawing.Color.Transparent;
            this.labelUID.Location = new System.Drawing.Point(136, 71);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(23, 12);
            this.labelUID.TabIndex = 29;
            this.labelUID.Text = "UID";
            // 
            // ChangeData
            // 
            this.ChangeData.Location = new System.Drawing.Point(134, 304);
            this.ChangeData.Name = "ChangeData";
            this.ChangeData.Size = new System.Drawing.Size(102, 45);
            this.ChangeData.TabIndex = 30;
            this.ChangeData.Text = "修改资料";
            this.ChangeData.UseVisualStyleBackColor = true;
            this.ChangeData.Click += new System.EventHandler(this.ChangeData_Click);
            // 
            // PersionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheRedFourm.Properties.Resources.解春困冲剂___愉快节奏来佐糖_109951163177059665;
            this.ClientSize = new System.Drawing.Size(343, 463);
            this.Controls.Add(this.ChangeData);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.comboBoxSEX);
            this.Controls.Add(this.textBoxHOB);
            this.Controls.Add(this.textBoxOCC);
            this.Controls.Add(this.textBoxAGE);
            this.Controls.Add(this.textBoxNAME);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.RegHOB);
            this.Controls.Add(this.RegOCC);
            this.Controls.Add(this.RegAGE);
            this.Controls.Add(this.RegSEX);
            this.Controls.Add(this.RegNAME);
            this.Controls.Add(this.RegPASSWORD);
            this.Controls.Add(this.RegUID);
            this.Name = "PersionData";
            this.Text = "个人资料";
            this.Load += new System.EventHandler(this.PersionData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSEX;
        private System.Windows.Forms.TextBox textBoxHOB;
        private System.Windows.Forms.TextBox textBoxOCC;
        private System.Windows.Forms.TextBox textBoxAGE;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.Label RegHOB;
        private System.Windows.Forms.Label RegOCC;
        private System.Windows.Forms.Label RegAGE;
        private System.Windows.Forms.Label RegSEX;
        private System.Windows.Forms.Label RegNAME;
        private System.Windows.Forms.Label RegPASSWORD;
        private System.Windows.Forms.Label RegUID;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Button ChangeData;
    }
}