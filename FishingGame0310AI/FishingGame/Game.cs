using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    public class Game
    {
        private int total = 0;
        private int kaisu = 3;
        static string path = @"C:\Users\ia\source\repos\FishingGame0310AI\FishingGame\fishScore.csv";

        public Game() { }
        public Game(int kaisu)
        {
            this.kaisu = kaisu;

        }
        public void Play()
        {
            Load();

            for (int i = 1; i <= kaisu; i++)
            {
                //ゲーム本体

                Console.WriteLine("\n{0}回目のチャレンジ！", i);


                Console.WriteLine("スポット選択　:　1～5の半角数字を入力して下さい");
                string readLine = Console.ReadLine();
                int select = int.Parse(readLine);
                if (select <= 5)
                {
                    Place p = new Place();
                    Console.WriteLine("選んだスポット：{0}", select);
                    //釣れた魚を表示
                    Console.WriteLine("釣れた魚：{0}\n", p.GetFish(select - 1));
                    total += (p.GetFish(select - 1).Pt);

                }
                else
                {
                    Console.WriteLine("【エラー】入力値が不正です。再度入力してください");
                    Play();
                }
            }
            Finish();



        }

        public void Load()
        {
            List<Score> scores;

            if (System.IO.File.Exists(path))
            {
                WriteLine();
                Console.WriteLine("前回のスコアを表示します");
                LoadFiles();
                WriteLine();

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                { }
                scores = new List<Score>();
                Console.WriteLine("\n\nはじめての釣りに挑戦！\n\n");
            }
        }
        private static List<Score> LoadFiles()
        {
            List<Score> list = new List<Score>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var values = line.Split(',');

                    //名前の取り出し
                    DateTime date = DateTime.Parse(values[0]);
                    int score = int.Parse(values[1]);
                    Console.WriteLine("{0} 【　合計{1}点　】", date, score);


                }
                sr.Close();
            }
            return list;

        }

        private void SaveData(string path, DateTime updateTime, int score)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {

                sw.Write(updateTime);
                sw.Write(",");
                sw.Write(score);
                sw.Write(",");
            }
        }




        private void Start()
        {
            //メッセージ表示＆得点を初期化
            Console.WriteLine("\n\n【釣りアプリ】\n\n");
            Play();

        }

        private void Finish()
        {
            //メッセージ表示＆合計得点表示
            WriteLine();
            Console.WriteLine("\n\nゲーム終了！合計点は{0}でした\n\n", total);
            int score = total;
            DateTime t = DateTime.Now;
            Console.WriteLine("今回のデータをセーブします。\n{0} 【　合計{1}点　】", t, score);
            SaveData(path, t, score);


        }
        private void WriteLine()
        {
            Console.WriteLine("==================================================");
        }


        static void Main(string[] args)
        {
            Game fishing = new Game();
            fishing.Start();

        }

    }
}
