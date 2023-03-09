using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCounter
{
/*    
・クラス名はAccessCounter
・ファイルパスを表すstring型のprivateなフィールドpathを持つ
・引数付きコンストラクタを持ちそこにstring型引数pathを与える
・引数付きコンストラクタでは引数をフィールドpathに代入する
・publicなメソッドLogでpathで指定した箇所にアクセスログを残す
・Logは戻り値なしで引数としてアクセス数（int）を与える
・ログは「2022年05月28日 09時30分21秒:100アクセス」の様に記録
・ログは上書き可能にすること
*/
    public class AccessCounter
    {
        private string path ="";

        public AccessCounter(string path)
        {
            this.path = path;
        }
        public void Log(int access)
        {
            using (StreamWriter sw = new StreamWriter(this.path, true, Encoding.UTF8))
            {
                DateTime t = DateTime.Now;
                sw.Write(t.ToString("\nyyyy年MM月dd日 hh時mm分ss秒"));
                /*string result=t.ToString("yyyy年MM月dd日 hh時mm分ss秒");
                sw.Write(result);*/
                sw.Write("{0}アクセス", access);
            }

        }


        static void Main(string[] args)
        {
            string file = "C:\\Users\\ia\\Desktop\\sample.txt";
            AccessCounter ac = new AccessCounter(file);
            ac.Log(100);

        }

 
    }


}
