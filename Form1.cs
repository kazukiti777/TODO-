using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TodoApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(@"c:\data\text.txt"))
            {
                TodoCommon todo = new TodoCommon();
                DetaCount(ref todo);
                FormSet(ref todo);
                this.AutoScroll = true;
                this.AutoScrollMargin = new Size(10, 10);
                this.AutoScrollMinSize = new Size(100, 100);

            }

        }

        public void FormSet(ref TodoCommon todo)
        {
            //メソッド参照
            string sTime = "";
            int Itimecnt1 = 0;
            int Itaskcnt2 = 0;
            int i = 0;

            //コントロール配列宣言
            this.TodoTime2 = new System.Windows.Forms.Label[todo.sText.Length];
            this.Taskanri2 = new System.Windows.Forms.Label[todo.sText.Length];
            DetaSelect Dselect = new DetaSelect();
            string s = Dselect.Data(ref todo);

            while (i < todo.sTask.Length && todo.icnt[i] != -1)
            {

                //TodoTime2(ラベル追加_コントロール配列)
                this.TodoTime2[i] = new Label();
                this.TodoTime2[i].AutoSize = false;
                this.TodoTime2[i].BackColor = System.Drawing.Color.PaleGreen;
                this.TodoTime2[i].Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.TodoTime2[i].ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.TodoTime2[i].ImageAlign = System.Drawing.ContentAlignment.TopRight;
                this.TodoTime2[i].Name = "TodoTime2";
                this.TodoTime2[i].Size = new System.Drawing.Size(223, 22);
                this.TodoTime2[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.TodoTime2[i].UseCompatibleTextRendering = true;
                this.TodoTime2[i].Parent = this;


                //TodoTask(ラベル追加_コントロール配列)
                this.Taskanri2[i] = new Label();
                this.Taskanri2[i].AutoSize = false;
                this.Taskanri2[i].BackColor = System.Drawing.Color.Moccasin;
                this.Taskanri2[i].Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
                this.Taskanri2[i].ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.Taskanri2[i].Name = "Taskanri2";
                this.Taskanri2[i].Size = new System.Drawing.Size(223, 42);
                this.Taskanri2[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                this.Taskanri2[i].Parent = this;

                switch (todo.iTimeCnt[i])
                {

                    case 1:
                        sTime = todo.sStart[i];
                        this.TodoTime2[i].Text = todo.sStart[i] + " (" + DateTime.Parse(todo.sStart[i]).ToString("ddd") + ")";
                        this.Taskanri2[i].Text = todo.sTime[i] + " " + todo.sTask[i];
                        this.TodoTime2[i].Location = new System.Drawing.Point(-1, 43);
                        this.Taskanri2[i].Location = new System.Drawing.Point(-1, 66);
                        this.TodoTime2[i].TabIndex = 5;
                        this.Taskanri2[i].TabIndex = 6;
                        Itimecnt1++;
                        Itaskcnt2++;
                        break;

                    default:
                        if (todo.icnt[i] == 1)
                        {
                            if (todo.icnt.Length - 1 == i - 1)
                            {
                                Itaskcnt2++;
                            }
                            sTime = todo.sStart[i];
                            this.TodoTime2[i].Text = todo.sStart[i] + " (" + DateTime.Parse(todo.sStart[i]).ToString("ddd") + ")";
                            this.Taskanri2[i].Text = todo.sTime[i] + " " + todo.sTask[i];
                            this.TodoTime2[i].Location = new System.Drawing.Point(-1, 43 + (22 * Itimecnt1) + (44 * Itaskcnt2));
                            this.Taskanri2[i].Location = new System.Drawing.Point(-1, 66 + (22 * Itimecnt1) + (44 * Itaskcnt2));
                            Itimecnt1++;
                            Itaskcnt2++;
                        }
                        else
                        {
                            this.Taskanri2[i].Text = todo.sTime[i] + " " + todo.sTask[i];
                            this.Taskanri2[i].Location = new System.Drawing.Point(-1, 43 + (22 * Itimecnt1) + (44 * Itaskcnt2));
                            Itaskcnt2++;
                        }
                        break;
                }
                i++;
            }
        }

        //追加処理
        private void button2_Click(object sender, EventArgs e)
        {
            //追加用ダイアログボックスOpen
            TestDaiaLog dlg = new TestDaiaLog();
            DialogResult digRet = dlg.ShowDialog();
            //更新後リソース解放
            UpdateRabel();
        }

        //編集・削除
        private void button3_Click(object sender, EventArgs e)
        {
            TodoCommon todo = new TodoCommon();
            DetaCount(ref todo);
            DeDaialog del = new DeDaialog(todo);
            DialogResult delRet = del.ShowDialog();

            //更新後リソース解放
            UpdateRabel();
        }

        public static void DetaCount(ref TodoCommon todo)
        {

            //ファイル存在チェック
            if (File.Exists(@"c:\data\text.txt"))
            {
                //読み込み
                string[] a = File.ReadAllLines(@"c:\data\text.txt", Encoding.GetEncoding("Shift_JIS"));

                todo.sTime = new string[a.Length];
                todo.sTask = new string[a.Length];
                todo.sStart = new string[a.Length];
                todo.icnt = new int[a.Length + 1];
                todo.iTimeCnt = new int[a.Length];
                todo.sText = new string[a.Length];
                todo.CheFlg = new int[a.Length];
                todo.icnt[todo.icnt.Length - 1] = -1;
                for (int i = 0; i < a.Length; i++)
                {
                    todo.sText[i] = a[i];
                    todo.CheFlg[i] = -1;
                }
            }
        }

        private void UpdateRabel()
        {
            for (int i = this.TodoTime2.Length - 1; 0 <= i; i--)
            {
                TodoTime2[i].Dispose();
                TodoTime2[i].Controls.Clear();
            }

            for (int i = this.Taskanri2.Length - 1; 0 <= i; i--)
            {
                Taskanri2[i].Dispose();
                Taskanri2[i].Controls.Clear();
            }
            StreamReader SaveFile = new StreamReader(@"c:\data\text.txt", Encoding.GetEncoding("Shift_JIS"));
            string text = SaveFile.ReadToEnd();
            SaveFile.Close();
            TodoCommon todo = new TodoCommon();
            DetaCount(ref todo);
            FormSet(ref todo);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

    }

    class DetaSelect : Form1
    {

        public String Data(ref TodoCommon todo)
        {
            long lCnt = 0;
            int TimeCnt = 1;
            int TimeCheck = 1;
            string sYotei = "";
            string sSyousai = "";
            string sTasuku = "";
            string sTaime = "";

            foreach (string text2 in todo.sText)
            {

                string[] smoji = text2.Split(' ');
                todo.sText[lCnt] = text2;
                bool isok = DateTime.TryParseExact(smoji[0], "yyyy/mm/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);
                if (sTaime == "")
                {
                    sTaime = smoji[0];
                    todo.iTimeCnt[0] = TimeCnt;
                }
                else if (DateTime.Parse(sTaime) < DateTime.Parse(smoji[0]))
                {
                    sTaime = smoji[0];
                    TimeCheck = 1;
                    todo.iTimeCnt[lCnt] = ++TimeCnt;
                }

                //年月日チェック
                if (isok)
                {
                    todo.sStart[lCnt] = smoji[0];
                    todo.sTime[lCnt] = smoji[1];
                    todo.sTask[lCnt] = smoji[2];
                    todo.icnt[lCnt] = TimeCheck;
                    todo.CheFlg[lCnt] = -1;
                    sYotei = smoji[1];
                    lCnt++;
                    TimeCheck++;
                }

                //時刻チェック
                else if (DateTime.TryParseExact(smoji[0], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime resk))
                {
                    todo.sTime[lCnt] = smoji[0];
                    todo.sTask[lCnt] = smoji[1];
                    todo.icnt[lCnt] = TimeCheck;
                    todo.CheFlg[lCnt] = -1;
                    sYotei = sYotei + " " + smoji[1];
                    lCnt++;
                    TimeCheck++;
                }

                //タスクチェック
                else if (smoji[1] != "")
                {
                    todo.sTime[lCnt] = smoji[0];
                    todo.sTask[lCnt] = smoji[1];
                    sSyousai = smoji[1];
                    lCnt++;
                }

                //最終チェック
                if (sYotei != "" && sSyousai != "")
                {
                    sTasuku = sTasuku + sYotei + "_" + sSyousai + ",";
                }
            }
            return sTasuku;
        }
    }
}
