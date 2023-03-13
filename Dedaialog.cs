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

    public partial class DeDaialog : Form
    {
        public static partial class TaskCount
        {
            //格納用
            static public TodoCommon Detodo = new TodoCommon();
            //更新用
            static public string UpdText;
        }


        public DeDaialog(TodoCommon todo)
        {
            InitializeComponent();
            TaskCount.UpdText = "";
            TaskCount.Detodo.sText = todo.sText;
            TaskCount.Detodo.CheFlg = todo.CheFlg;
            foreach (string a in TaskCount.Detodo.sText)
            {
                TaskCount.UpdText = TaskCount.UpdText + a + "\r\n";
            }
        }


        private void DateSet(TodoCommon todo)
        {
            int i = 0;
            DataTable dt = (DataTable)TaskDate.DataSource;
            if (dt != null) { dt.Clear(); }
            while (todo.sText.Length > i)
            {
                string[] sStask = todo.sText[i].Split(' ');
                todo.sStart[i] = sStask[0];
                todo.sTime[i] = sStask[1];
                todo.sTask[i] = sStask[2];
                TaskDate.Rows.Add(false, TaskCount.Detodo.sStart[i], TaskCount.Detodo.sTime[i], TaskCount.Detodo.sTask[i]);
                TaskDate.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
                TaskDate.Rows[i].Cells[0].ReadOnly = false;
                i = i + 1;
            }
        }

        private void DeDaialog_Load(object Sender, EventArgs e)
        {

            //初期データセット
            TaskCount.Detodo.sStart = new string[TaskCount.Detodo.sText.Length];
            TaskCount.Detodo.sTask = new string[TaskCount.Detodo.sText.Length];
            TaskCount.Detodo.sTime = new string[TaskCount.Detodo.sText.Length];

            //画面にセット(初期表示)
            TaskDate.ReadOnly = true;
            TaskDate.ColumnCount = 4;
            TaskDate.Columns[0].Width = 60;
            TaskDate.Columns[1].Width = 80;
            TaskDate.Columns[2].Width = 60;
            TaskDate.Columns[3].Width = 181;
            TaskDate.Columns[0].HeaderText = "削除";
            TaskDate.Columns[1].HeaderText = "日付";
            TaskDate.Columns[2].HeaderText = "時間";
            TaskDate.Columns[3].HeaderText = "内容";
            TaskDate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TaskDate.AllowUserToAddRows = false;
            TaskDate.AllowUserToOrderColumns = false;
            DateSet(TaskCount.Detodo);
        }

        //更新処理
        private void button1_Click(object sender, EventArgs e)
        {
            string FilePach = @"c:\data\text.txt";
            string Dat = TaskCount.UpdText;
            try
            {
                switch (radioButton1.Checked)
                {
                    case true:
                        //更新(削除)
                        Syori.DeleteText(FilePach, Dat, TaskCount.Detodo);
                        TaskCount.Detodo.sText = File.ReadAllLines(FilePach, Encoding.GetEncoding("Shift_JIS"));
                        DateSet(TaskCount.Detodo);
                        break;

                    case false:
                        //更新(編集)
                        Syori.UpdateText(FilePach, Dat, TaskCount.Detodo);
                        break;
                }
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void TaskHenkou1_LostFocus(object sender, EventArgs e)
        {

            if (TaskHenkou1.TextLength >= 8)
            {
                TaskHenkou1.Text = Syori.TextFormat(TaskHenkou1.Text);
            }
            else
            {
                MessageBox.Show("日付形式となっておりません。");
            }
        }

        private void TaskHenkou2_LostFocus(object sender, EventArgs e)
        {

            if (TaskHenkou2.TextLength >= 3)
            {
                TaskHenkou2.Text = Syori.TextFormat(TaskHenkou2.Text);
            }
            else
            {
                MessageBox.Show("時間形式となっておりません。");
            }
        }

        private void 反映_Click(object sender, EventArgs e)
        {
            //編集対応判定
            if (radioButton2.Checked)
            {
                int cnt = TaskDate.CurrentCell.RowIndex;
                TaskDate[1, cnt].Value = TaskHenkou1.Text;
                TaskDate[2, cnt].Value = TaskHenkou2.Text;
                TaskDate[3, cnt].Value = TaskHenkou3.Text;
                TaskCount.Detodo.CheFlg[TaskDate.CurrentCell.RowIndex] = cnt;
                TaskCount.Detodo.sStart[cnt] = TaskDate[1, cnt].Value.ToString();
                TaskCount.Detodo.sTime[cnt] = TaskDate[2, cnt].Value.ToString();
                TaskCount.Detodo.sTask[cnt] = TaskDate[3, cnt].Value.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.TaskHenkou1.Text = "";
            this.TaskHenkou2.Text = "";
            this.TaskHenkou3.Text = "";
            this.TaskHenkou1.Enabled = false;
            this.TaskHenkou2.Enabled = false;
            this.TaskHenkou3.Enabled = false;
            this.button1.Enabled = true;
            TaskDate.Columns[0].ReadOnly = true;
            for (int i = TaskDate.Rows.Count - 1; i >= 0; i--)
            {
                if (TaskCount.Detodo.sText[i] != TaskDate[1, i].Value.ToString() + " " + TaskDate[3, i].Value.ToString() + " " + TaskDate[2, i].Value.ToString())
                {
                    string[] a = TaskCount.Detodo.sText[i].Split(' ');
                    TaskDate[1, i].Value = a[0];
                    TaskDate[2, i].Value = a[1];
                    TaskDate[3, i].Value = a[2];
                    TaskCount.Detodo.sStart[i] = a[0];
                    TaskCount.Detodo.sTime[i] = a[1];
                    TaskCount.Detodo.sTask[i] = a[2];
                    TaskDate.Rows[i].Cells[0].Style.BackColor = Color.White;

                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.TaskHenkou1.Enabled = true;
            this.TaskHenkou2.Enabled = true;
            this.TaskHenkou3.Enabled = true;
            TaskHenkou1.Text = TaskDate[1, TaskDate.CurrentCell.RowIndex].Value.ToString();
            TaskHenkou2.Text = TaskDate[2, TaskDate.CurrentCell.RowIndex].Value.ToString();
            TaskHenkou3.Text = TaskDate[3, TaskDate.CurrentCell.RowIndex].Value.ToString();
            this.button1.Enabled = false;
            TaskDate.Columns[0].ReadOnly = false;
            for (int i = TaskDate.Rows.Count - 1; i >= 0; i--)
            {
                switch (TaskDate.Rows[i].Cells[0].Value)
                {
                    case true:
                        TaskCount.Detodo.CheFlg[i] = -1;
                        TaskDate.Rows[i].Cells[0].Value = false;
                        TaskDate.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        TaskDate.Rows[i].Cells[0].Style.BackColor = Color.DarkGray;

                        break;

                    case false:
                        TaskCount.Detodo.CheFlg[i] = -1;
                        TaskDate.Rows[i].Cells[0].Value = false;
                        TaskDate.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        TaskDate.Rows[i].Cells[0].Style.BackColor = Color.DarkGray;
                        break;
                }
            }
        }

        //イベント
        private void TaskDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (radioButton2.Checked)
            {

                this.TaskHenkou1.Text = TaskDate[1, TaskDate.CurrentCell.RowIndex].Value.ToString();
                this.TaskHenkou2.Text = TaskDate[2, TaskDate.CurrentCell.RowIndex].Value.ToString();
                this.TaskHenkou3.Text = TaskDate[3, TaskDate.CurrentCell.RowIndex].Value.ToString();
            }
            else if (radioButton1.Checked)
            {
                switch (TaskDate.Rows[TaskDate.CurrentCell.RowIndex].Cells[0].Value)
                {
                    case false:
                        TaskDate.Rows[TaskDate.CurrentCell.RowIndex].Cells[0].Value = true;
                        TaskCount.Detodo.CheFlg[TaskDate.CurrentCell.RowIndex] = TaskDate.CurrentCell.RowIndex;
                        TaskDate.Rows[TaskDate.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                        TaskDate.Rows[TaskDate.CurrentCell.RowIndex].Cells[0].Style.BackColor = Color.White;
                        break;

                    case true:
                        TaskDate.Rows[TaskDate.CurrentCell.RowIndex].Cells[0].Value = false;
                        TaskCount.Detodo.CheFlg[TaskDate.CurrentCell.RowIndex] = -1;
                        TaskDate.Rows[TaskDate.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        //全選択処理
        private void button1_Click_1(object sender, EventArgs e)
        {

            switch (button1.Text)
            {

                case "全選択":
                    for (int i = 0; i < TaskDate.Rows.Count; i++)
                    {
                        int x = 3;
                        TaskDate[0, i].Value = true;
                        TaskCount.Detodo.CheFlg[i] = i;
                        TaskDate.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        TaskDate.Rows[i].Cells[0].Style.BackColor = Color.White;
                    }
                    button1.Text = "全解除";
                    break;
                case "全解除":
                    for (int i = 0; i < TaskDate.Rows.Count; i++)
                    {
                        TaskDate[0, i].Value = false;
                        TaskCount.Detodo.CheFlg[i] = -1;
                        TaskDate.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                    button1.Text = "全選択";
                    break;
            }

        }
    }

    class Syori
    {
        static public string UpdateText(string FilePach, string sText, TodoCommon todo)
        {

            try
            {

                //選択されたデータを抽出
                Boolean bRet = false;
                var query = todo.CheFlg.Where(x => { return x > -1; });
                foreach (var b in query)
                {
                    string tmp = todo.sText[b];
                    todo.sText[b] = todo.sStart[b] + " " + todo.sTime[b] + " " + todo.sTask[b];
                    if (b == todo.sStart.Length && DateTime.Parse(todo.sStart[b]) >= DateTime.Parse(todo.sStart[b - 1]))
                    {
                        bRet = true;
                    }
                    else if (b == 0 && DateTime.Parse(todo.sStart[b]) <= DateTime.Parse(todo.sStart[b + 1]))
                    {
                        bRet = true;
                    }

                    if (DateTime.Parse(todo.sStart[b]) <= DateTime.Parse(todo.sStart[b + 1]) && DateTime.Parse(todo.sStart[b]) >= DateTime.Parse(todo.sStart[b - 1]) && bRet == false)
                    {
                        sText = sText.Replace(tmp, todo.sText[b]);
                    }
                    else
                    {
                        sText = "";
                        Array.Sort(todo.sText);
                        for (int i = 0; i <= todo.sText.Length - 1; i++)
                        {
                            sText = sText + todo.sText[i] + "\r\n";
                        }
                    }


                }
                FileStream file = new FileStream(FilePach, FileMode.Open);
                file.SetLength(0);
                file.Close();
                StreamWriter sw = new StreamWriter(FilePach, true, Encoding.GetEncoding("Shift_JIS"));
                sw.Write(sText);
                sw.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sText;
        }

        static public string DeleteText(string FilePach, string sText, TodoCommon todo)
        {
            try
            {
                var query = todo.CheFlg.Where(x => { return x > -1; });
                foreach (var b in query)
                {
                    string tmp = todo.sText[b] + "\r\n";
                    sText = sText.Replace(tmp, "");
                }
                FileStream file = new FileStream(FilePach, FileMode.Open);
                file.SetLength(0);
                file.Close();
                StreamWriter sw = new StreamWriter(FilePach, true, Encoding.GetEncoding("Shift_JIS"));
                sw.Write(sText);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sText;
        }


        static public string TextFormat(string sText)
        {
            if (string.IsNullOrEmpty(sText)) { return string.Empty; }
            switch (sText.Length)
            {

                case 8:
                    sText = sText.Insert(4, "/");
                    sText = sText.Insert(7, "/");
                    break;

                case 4:
                    sText = sText.Insert(2, ":");
                    break;
                case 3:
                    sText = sText.Insert(1, ":");
                    break;
            }
            return sText;
        }
    }

}
