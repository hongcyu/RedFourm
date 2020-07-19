namespace TheRedFourm.RETEXT
{
    partial class QueryRetext
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
            this.queryofretext = new System.Windows.Forms.DataGridView();
            this.timeofretext = new System.Windows.Forms.TextBox();
            this.Queryretextbutton = new System.Windows.Forms.Button();
            this.contextMenuStripofretext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uidofretext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerofretext = new System.Windows.Forms.DateTimePicker();
            this.chongzhi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryofretext)).BeginInit();
            this.contextMenuStripofretext.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryofretext
            // 
            this.queryofretext.AllowUserToAddRows = false;
            this.queryofretext.AllowUserToDeleteRows = false;
            this.queryofretext.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queryofretext.BackgroundColor = System.Drawing.SystemColors.Control;
            this.queryofretext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryofretext.Location = new System.Drawing.Point(2, 65);
            this.queryofretext.Name = "queryofretext";
            this.queryofretext.ReadOnly = true;
            this.queryofretext.RowTemplate.Height = 23;
            this.queryofretext.Size = new System.Drawing.Size(931, 577);
            this.queryofretext.TabIndex = 0;
            // 
            // timeofretext
            // 
            this.timeofretext.Location = new System.Drawing.Point(440, 21);
            this.timeofretext.Name = "timeofretext";
            this.timeofretext.Size = new System.Drawing.Size(99, 21);
            this.timeofretext.TabIndex = 2;
            // 
            // Queryretextbutton
            // 
            this.Queryretextbutton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Queryretextbutton.Location = new System.Drawing.Point(600, 12);
            this.Queryretextbutton.Name = "Queryretextbutton";
            this.Queryretextbutton.Size = new System.Drawing.Size(94, 41);
            this.Queryretextbutton.TabIndex = 3;
            this.Queryretextbutton.Text = "查询";
            this.Queryretextbutton.UseVisualStyleBackColor = true;
            this.Queryretextbutton.Click += new System.EventHandler(this.Queryretextbutton_Click);
            // 
            // contextMenuStripofretext
            // 
            this.contextMenuStripofretext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripofretext.Name = "contextMenuStripofretext";
            this.contextMenuStripofretext.Size = new System.Drawing.Size(101, 48);
            // 
            // lookToolStripMenuItem
            // 
            this.lookToolStripMenuItem.Name = "lookToolStripMenuItem";
            this.lookToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.lookToolStripMenuItem.Text = "查看";
            this.lookToolStripMenuItem.Click += new System.EventHandler(this.LookToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(379, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "日期：";
            // 
            // uidofretext
            // 
            this.uidofretext.Location = new System.Drawing.Point(228, 22);
            this.uidofretext.Name = "uidofretext";
            this.uidofretext.Size = new System.Drawing.Size(115, 21);
            this.uidofretext.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(147, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户ID：";
            // 
            // dateTimePickerofretext
            // 
            this.dateTimePickerofretext.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickerofretext.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerofretext.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerofretext.Location = new System.Drawing.Point(440, 21);
            this.dateTimePickerofretext.Name = "dateTimePickerofretext";
            this.dateTimePickerofretext.Size = new System.Drawing.Size(130, 21);
            this.dateTimePickerofretext.TabIndex = 1;
            this.dateTimePickerofretext.ValueChanged += new System.EventHandler(this.DateTimePickerofretext_ValueChanged);
            // 
            // chongzhi
            // 
            this.chongzhi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chongzhi.Location = new System.Drawing.Point(724, 15);
            this.chongzhi.Name = "chongzhi";
            this.chongzhi.Size = new System.Drawing.Size(87, 38);
            this.chongzhi.TabIndex = 8;
            this.chongzhi.Text = "重置";
            this.chongzhi.UseVisualStyleBackColor = true;
            this.chongzhi.Click += new System.EventHandler(this.Chongzhi_Click);
            // 
            // QueryRetext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheRedFourm.Properties.Resources._006z09Zkgy1fm5xg8987rj30m80wzgqr;
            this.ClientSize = new System.Drawing.Size(933, 643);
            this.Controls.Add(this.chongzhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uidofretext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Queryretextbutton);
            this.Controls.Add(this.timeofretext);
            this.Controls.Add(this.dateTimePickerofretext);
            this.Controls.Add(this.queryofretext);
            this.Name = "QueryRetext";
            this.Text = "QueryRetext";
            this.Load += new System.EventHandler(this.QueryRetext_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryofretext)).EndInit();
            this.contextMenuStripofretext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView queryofretext;
        private System.Windows.Forms.TextBox timeofretext;
        private System.Windows.Forms.Button Queryretextbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripofretext;
        private System.Windows.Forms.ToolStripMenuItem lookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uidofretext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerofretext;
        private System.Windows.Forms.Button chongzhi;
    }
}