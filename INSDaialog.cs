using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TodoApp1
{
    public partial class TestDaiaLog : System.Windows.Forms.Form
    {
        public static partial class TaskCount
        {
            //格納用
            static public TodoCommon Uptodo = new TodoCommon();
        }

        public string TextSert
        {
            get { { return this.TextSert; } }
            set { { TextSert = value; } }
        }

        public TestDaiaLog()
        {
            InitializeComponent();
        }


        private void TestDaiaLog_Load(object sender, EventArgs e)
        {

            Form1 fr1 = new Form1();
            fr1.Hide();
            //現在日付取得
            textBox2.Text = DateTime.Now.ToString("yyyy/MM/dd");
            //TaskCount.Uptodo.sText = 
        }

        private void TextBox2_LostFocre(object sender, EventArgs e)
        {
            switch (textBox2.Text.Length)
            {
                case 8:
                    textBox2.Text = textBox1.Text.Insert(4, "/");
                    textBox2.Text = textBox1.Text.Insert(7, "/");
                    break;
            }
        }

        private void カレンダー_Click(object sender, EventArgs e)
        {

            Calendar cle = new Calendar();
            cle.ShowDialog(this);
            textBox2.Text = cle.SelectDate;

        }

        private void 追加_Click(object sender, EventArgs e)
        {

            //初期化
            string filePath = "";
            string text = "";
            filePath = @"c:\data\text.txt";

            if (System.IO.File.Exists(filePath))
            {
                string[] a = File.ReadAllLines(filePath, Encoding.GetEncoding("Shift_JIS"));
                Array.Resize(ref a, a.Length + 1);
                a[a.Length - 1] = textBox2.Text + " " + dateTimePicker1.Text + " " + textBox1.Text;
                Array.Sort(a);
                for (int i = 0; i < a.Length; i++)
                {
                    text = text + a[i] + "\r\n";
                }
                FileStream file = new FileStream(filePath, FileMode.Open);
                file.SetLength(0);
                file.Close();
                StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding("Shift_JIS"));
                sw.Write(text);
                sw.Close();
                this.Close();
            }
            else
            {
                if (text == "")
                {
                    text = textBox2.Text + " " + dateTimePicker1.Text + " " + textBox1.Text;
                    StreamWriter sw1 = File.CreateText(filePath);
                    sw1.WriteLine(text);
                    sw1.Close();
                    this.Close();
                }
                else
                {
                    text = text + textBox2.Text + " " + dateTimePicker1.Text + " " + textBox1.Text;
                    StreamWriter sw1 = File.CreateText(filePath);
                    sw1.WriteLine(text);
                    sw1.Close();
                    this.Close();
                }
            }
        }
    }
}
