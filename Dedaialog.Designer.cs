namespace TodoApp1
{
    partial class DeDaialog
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
            this.削除 = new System.Windows.Forms.Button();
            this.反映 = new System.Windows.Forms.Button();
            this.TaskHenkou3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaskHenkou1 = new System.Windows.Forms.TextBox();
            this.TaskHenkou2 = new System.Windows.Forms.TextBox();
            this.TaskDate = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.日付 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDate)).BeginInit();
            this.SuspendLayout();
            // 
            // 削除
            // 
            this.削除.Location = new System.Drawing.Point(399, 242);
            this.削除.Name = "削除";
            this.削除.Size = new System.Drawing.Size(69, 25);
            this.削除.TabIndex = 1;
            this.削除.Text = "更新";
            this.削除.UseVisualStyleBackColor = true;
            this.削除.Click += new System.EventHandler(this.button1_Click);
            // 
            // 反映
            // 
            this.反映.Location = new System.Drawing.Point(254, 223);
            this.反映.Name = "反映";
            this.反映.Size = new System.Drawing.Size(69, 23);
            this.反映.TabIndex = 2;
            this.反映.Text = "反映";
            this.反映.UseVisualStyleBackColor = true;
            this.反映.Click += new System.EventHandler(this.反映_Click);
            // 
            // TaskHenkou3
            // 
            this.TaskHenkou3.Enabled = false;
            this.TaskHenkou3.Location = new System.Drawing.Point(74, 225);
            this.TaskHenkou3.Name = "TaskHenkou3";
            this.TaskHenkou3.Size = new System.Drawing.Size(174, 19);
            this.TaskHenkou3.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 174);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "削除";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 201);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "編集";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(74, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "全選択";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TaskHenkou1
            // 
            this.TaskHenkou1.Enabled = false;
            this.TaskHenkou1.Location = new System.Drawing.Point(74, 200);
            this.TaskHenkou1.Name = "TaskHenkou1";
            this.TaskHenkou1.Size = new System.Drawing.Size(76, 19);
            this.TaskHenkou1.TabIndex = 9;
            this.TaskHenkou1.LostFocus += new System.EventHandler(this.TaskHenkou1_LostFocus);
            // 
            // TaskHenkou2
            // 
            this.TaskHenkou2.Enabled = false;
            this.TaskHenkou2.Location = new System.Drawing.Point(156, 200);
            this.TaskHenkou2.Name = "TaskHenkou2";
            this.TaskHenkou2.Size = new System.Drawing.Size(46, 19);
            this.TaskHenkou2.TabIndex = 10;
            this.TaskHenkou2.LostFocus += new System.EventHandler(this.TaskHenkou2_LostFocus);
            // 
            // TaskDate
            // 
            this.TaskDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.日付,
            this.時間,
            this.内容});
            this.TaskDate.Location = new System.Drawing.Point(21, 12);
            this.TaskDate.Name = "TaskDate";
            this.TaskDate.RowTemplate.Height = 21;
            this.TaskDate.Size = new System.Drawing.Size(425, 150);
            this.TaskDate.TabIndex = 0;
            this.TaskDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskDate_CellClick);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "削除";
            this.Column0.Name = "Column0";
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column0.Width = 60;
            // 
            // 日付
            // 
            this.日付.HeaderText = "日付";
            this.日付.Name = "日付";
            this.日付.Width = 80;
            // 
            // 時間
            // 
            this.時間.HeaderText = "時間";
            this.時間.Name = "時間";
            this.時間.Width = 60;
            // 
            // 内容
            // 
            this.内容.HeaderText = "内容";
            this.内容.Name = "内容";
            this.内容.Width = 181;
            // 
            // DeDaialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 270);
            this.Controls.Add(this.TaskHenkou2);
            this.Controls.Add(this.TaskHenkou1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TaskHenkou3);
            this.Controls.Add(this.反映);
            this.Controls.Add(this.削除);
            this.Controls.Add(this.TaskDate);
            this.Name = "DeDaialog";
            this.Text = "項目編集";
            this.Load += new System.EventHandler(this.DeDaialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button 削除;
        private System.Windows.Forms.Button 反映;
        private System.Windows.Forms.TextBox TaskHenkou3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TaskHenkou1;
        private System.Windows.Forms.TextBox TaskHenkou2;
        private System.Windows.Forms.DataGridView TaskDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付;
        private System.Windows.Forms.DataGridViewTextBoxColumn 時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内容;
    }
}