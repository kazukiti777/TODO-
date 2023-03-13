using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp1
{
    public class TodoCommon
    {
        //全データタスク
        public string[] sText { set; get; }

        //開始日
        public string[] sTime { set; get; }

        //タスクに登録される予定
        public string[] sTask { set; get; }

        //開始時間
        public string[] sStart { set; get; }

        //詳細
        public int[] icnt { set; get; }

        //日付カウント
        public int[] iTimeCnt { set; get; }


        //編集フラグ
        public int[] CheFlg { set; get; }

    }

}
