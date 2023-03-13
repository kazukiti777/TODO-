namespace TodoApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TodoTime = new System.Windows.Forms.Label();
            this.Taskanri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(-1, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "＋";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(111, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TodoTime
            // 
            this.TodoTime.BackColor = System.Drawing.Color.PaleGreen;
            this.TodoTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TodoTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TodoTime.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.TodoTime.Location = new System.Drawing.Point(-1, 42);
            this.TodoTime.Name = "TodoTime";
            this.TodoTime.Size = new System.Drawing.Size(223, 32);
            this.TodoTime.TabIndex = 3;
            this.TodoTime.Text = "2022/12/30 (月)";
            this.TodoTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TodoTime.UseCompatibleTextRendering = true;
            this.TodoTime.Visible = false;
            // 
            // Taskanri
            // 
            this.Taskanri.BackColor = System.Drawing.Color.Moccasin;
            this.Taskanri.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Taskanri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Taskanri.Location = new System.Drawing.Point(-1, 74);
            this.Taskanri.Name = "Taskanri";
            this.Taskanri.Size = new System.Drawing.Size(223, 42);
            this.Taskanri.TabIndex = 4;
            this.Taskanri.Text = "22:00 テスト作成";
            this.Taskanri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Taskanri.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(223, 490);
            this.Controls.Add(this.Taskanri);
            this.Controls.Add(this.TodoTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "ToDoタスク";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label TodoTime;
        private System.Windows.Forms.Label Taskanri;
        private System.Windows.Forms.Label[] TodoTime2;
        private System.Windows.Forms.Label[] Taskanri2;

    }
}

