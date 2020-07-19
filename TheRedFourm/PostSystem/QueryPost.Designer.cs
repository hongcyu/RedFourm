namespace TheRedFourm.PostSystem
{
    partial class QueryPost
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
            this.deleteMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QueryUID = new System.Windows.Forms.TextBox();
            this.QueryPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Qpost = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.chongzhipost = new System.Windows.Forms.Button();
            this.dataGridViewpost = new System.Windows.Forms.DataGridView();
            this.deleteMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpost)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteMenuStrip
            // 
            this.deleteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.deleteMenuStrip.Name = "deleteMenuStrip";
            this.deleteMenuStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            this.查看ToolStripMenuItem.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // QueryUID
            // 
            this.QueryUID.Location = new System.Drawing.Point(194, 19);
            this.QueryUID.Name = "QueryUID";
            this.QueryUID.Size = new System.Drawing.Size(92, 21);
            this.QueryUID.TabIndex = 1;
            // 
            // QueryPID
            // 
            this.QueryPID.Location = new System.Drawing.Point(361, 19);
            this.QueryPID.Name = "QueryPID";
            this.QueryPID.Size = new System.Drawing.Size(92, 21);
            this.QueryPID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(125, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(292, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "帖子ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(462, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "日期";
            // 
            // Qpost
            // 
            this.Qpost.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Qpost.Location = new System.Drawing.Point(678, 13);
            this.Qpost.Name = "Qpost";
            this.Qpost.Size = new System.Drawing.Size(87, 32);
            this.Qpost.TabIndex = 6;
            this.Qpost.Text = "查询";
            this.Qpost.UseVisualStyleBackColor = true;
            this.Qpost.Click += new System.EventHandler(this.Qpost_Click);
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy/MM/dd";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(516, 19);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(116, 21);
            this.dateTime.TabIndex = 8;
            this.dateTime.ValueChanged += new System.EventHandler(this.DateTime_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 21);
            this.textBox1.TabIndex = 2;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(516, 19);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(90, 21);
            this.time.TabIndex = 9;
            // 
            // chongzhipost
            // 
            this.chongzhipost.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chongzhipost.Location = new System.Drawing.Point(786, 13);
            this.chongzhipost.Name = "chongzhipost";
            this.chongzhipost.Size = new System.Drawing.Size(87, 32);
            this.chongzhipost.TabIndex = 10;
            this.chongzhipost.Text = "重置";
            this.chongzhipost.UseVisualStyleBackColor = true;
            this.chongzhipost.Click += new System.EventHandler(this.Chongzhipost_Click);
            // 
            // dataGridViewpost
            // 
            this.dataGridViewpost.AllowUserToAddRows = false;
            this.dataGridViewpost.AllowUserToDeleteRows = false;
            this.dataGridViewpost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewpost.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewpost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpost.ContextMenuStrip = this.deleteMenuStrip;
            this.dataGridViewpost.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewpost.Location = new System.Drawing.Point(1, 66);
            this.dataGridViewpost.Name = "dataGridViewpost";
            this.dataGridViewpost.ReadOnly = true;
            this.dataGridViewpost.RowTemplate.Height = 23;
            this.dataGridViewpost.Size = new System.Drawing.Size(931, 577);
            this.dataGridViewpost.TabIndex = 0;
            // 
            // QueryPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheRedFourm.Properties.Resources._006z09Zkgy1fm5xg9dvdfj30m80vg78x;
            this.ClientSize = new System.Drawing.Size(933, 643);
            this.Controls.Add(this.chongzhipost);
            this.Controls.Add(this.time);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.Qpost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QueryPID);
            this.Controls.Add(this.QueryUID);
            this.Controls.Add(this.dataGridViewpost);
            this.Name = "QueryPost";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            this.deleteMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox QueryUID;
        private System.Windows.Forms.TextBox QueryPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Qpost;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.ContextMenuStrip deleteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button chongzhipost;
        private System.Windows.Forms.DataGridView dataGridViewpost;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
    }
}