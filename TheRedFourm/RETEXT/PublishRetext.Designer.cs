namespace TheRedFourm.RETEXT
{
    partial class PublishRetext
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.showPID = new System.Windows.Forms.Label();
            this.titletext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maintext = new System.Windows.Forms.TextBox();
            this.retextbox = new System.Windows.Forms.TextBox();
            this.retext1 = new System.Windows.Forms.Button();
            this.dataGridViewofretext = new System.Windows.Forms.DataGridView();
            this.contextMenuStripofretext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deldeteretext = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewofretext)).BeginInit();
            this.contextMenuStripofretext.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前帖子ID：";
            // 
            // showPID
            // 
            this.showPID.AutoSize = true;
            this.showPID.BackColor = System.Drawing.Color.Transparent;
            this.showPID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showPID.Location = new System.Drawing.Point(139, 9);
            this.showPID.Name = "showPID";
            this.showPID.Size = new System.Drawing.Size(55, 21);
            this.showPID.TabIndex = 1;
            this.showPID.Text = "label2";
            // 
            // titletext
            // 
            this.titletext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titletext.Location = new System.Drawing.Point(143, 78);
            this.titletext.MaxLength = 50;
            this.titletext.Name = "titletext";
            this.titletext.ReadOnly = true;
            this.titletext.Size = new System.Drawing.Size(663, 29);
            this.titletext.TabIndex = 2;
            this.titletext.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "标题：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(38, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "内容：";
            // 
            // maintext
            // 
            this.maintext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maintext.Location = new System.Drawing.Point(143, 136);
            this.maintext.MaxLength = 500;
            this.maintext.Multiline = true;
            this.maintext.Name = "maintext";
            this.maintext.ReadOnly = true;
            this.maintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.maintext.Size = new System.Drawing.Size(663, 386);
            this.maintext.TabIndex = 5;
            this.maintext.TabStop = false;
            // 
            // retextbox
            // 
            this.retextbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.retextbox.Location = new System.Drawing.Point(143, 588);
            this.retextbox.Name = "retextbox";
            this.retextbox.Size = new System.Drawing.Size(559, 29);
            this.retextbox.TabIndex = 6;
            // 
            // retext1
            // 
            this.retext1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.retext1.Location = new System.Drawing.Point(747, 587);
            this.retext1.Name = "retext1";
            this.retext1.Size = new System.Drawing.Size(59, 30);
            this.retext1.TabIndex = 7;
            this.retext1.Text = "回复";
            this.retext1.UseVisualStyleBackColor = true;
            this.retext1.Click += new System.EventHandler(this.Retext1_Click);
            // 
            // dataGridViewofretext
            // 
            this.dataGridViewofretext.AllowUserToAddRows = false;
            this.dataGridViewofretext.AllowUserToDeleteRows = false;
            this.dataGridViewofretext.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewofretext.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewofretext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewofretext.ContextMenuStrip = this.contextMenuStripofretext;
            this.dataGridViewofretext.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewofretext.Location = new System.Drawing.Point(145, 650);
            this.dataGridViewofretext.Name = "dataGridViewofretext";
            this.dataGridViewofretext.ReadOnly = true;
            this.dataGridViewofretext.RowTemplate.Height = 23;
            this.dataGridViewofretext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewofretext.Size = new System.Drawing.Size(660, 182);
            this.dataGridViewofretext.TabIndex = 8;
            // 
            // contextMenuStripofretext
            // 
            this.contextMenuStripofretext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deldeteretext});
            this.contextMenuStripofretext.Name = "contextMenuStripofretext";
            this.contextMenuStripofretext.Size = new System.Drawing.Size(101, 26);
            // 
            // deldeteretext
            // 
            this.deldeteretext.Name = "deldeteretext";
            this.deldeteretext.Size = new System.Drawing.Size(100, 22);
            this.deldeteretext.Text = "删除";
            this.deldeteretext.Click += new System.EventHandler(this.Deldeteretext_Click);
            // 
            // PublishRetext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheRedFourm.Properties.Resources._006z09Zkgy1fm5xg9dvdfj30m80vg78x;
            this.ClientSize = new System.Drawing.Size(912, 844);
            this.Controls.Add(this.dataGridViewofretext);
            this.Controls.Add(this.retext1);
            this.Controls.Add(this.retextbox);
            this.Controls.Add(this.maintext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titletext);
            this.Controls.Add(this.showPID);
            this.Controls.Add(this.label1);
            this.Name = "PublishRetext";
            this.Text = "PublishRetext";
            this.Load += new System.EventHandler(this.PublishRetext_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewofretext)).EndInit();
            this.contextMenuStripofretext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showPID;
        private System.Windows.Forms.TextBox titletext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maintext;
        private System.Windows.Forms.TextBox retextbox;
        private System.Windows.Forms.Button retext1;
        private System.Windows.Forms.DataGridView dataGridViewofretext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripofretext;
        private System.Windows.Forms.ToolStripMenuItem deldeteretext;
    }
}