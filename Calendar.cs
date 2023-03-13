using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp1
{
    public partial class Calendar : System.Windows.Forms.Form
    {

        public static string SelectDt;

        public string SelectDate
        {
            get
            {
                return SelectDt;
            }

            set
            {
                SelectDt = value;
            }

        }


        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            monthCalendar1.DateSelected += new DateRangeEventHandler(monthCalendar1_DateSelected);
        }


        void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //表示(年月日の取得)
            label1.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");

        }


        private void button1_Click(object sender, EventArgs e)
        {

            //年月日取得
            SelectDt = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");

            //閉じる
            this.Close();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
