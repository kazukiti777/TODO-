namespace TodoApp1
{
    partial class TestDaiaLog
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.追加 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.カレンダー = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年月日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "予定内容";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 19);
            this.textBox1.TabIndex = 5;
            // 
            // 追加
            // 
            this.追加.Location = new System.Drawing.Point(380, 186);
            this.追加.Name = "追加";
            this.追加.Size = new System.Drawing.Size(75, 23);
            this.追加.TabIndex = 6;
            this.追加.Text = "追加";
            this.追加.UseVisualStyleBackColor = true;
            this.追加.Click += new System.EventHandler(this.追加_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "2022/04/07";
            this.textBox2.LostFocus += new System.EventHandler(this.TextBox2_LostFocre);
            // 
            // カレンダー
            // 
            this.カレンダー.Location = new System.Drawing.Point(110, 34);
            this.カレンダー.Name = "カレンダー";
            this.カレンダー.Size = new System.Drawing.Size(56, 23);
            this.カレンダー.TabIndex = 8;
            this.カレンダー.Text = "カレンダー";
            this.カレンダー.UseVisualStyleBackColor = true;
            this.カレンダー.Click += new System.EventHandler(this.カレンダー_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 19);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // TestDaiaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 221);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.カレンダー);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.追加);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestDaiaLog";
            this.Text = "追加";
            this.Load += new System.EventHandler(this.TestDaiaLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 追加;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button カレンダー;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}