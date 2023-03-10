using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Game(){ }
        public Game(int kaisu)
        {
            this.kaisu = kaisu;

        }
        public void Play()
        {

            for(int i = 1; i <= kaisu; i++)
            {
                //ゲーム本体

                Console.WriteLine("{0}回目のチャレンジ！", i);
                

                Console.WriteLine("スポット選択　:　1～5の半角数字を入力して下さい");
                string readLine = Console.ReadLine();
                int select = int.Parse(readLine);
                if (select <= 5)
                {
                    //var fished = new HashSet<Fish>();
                    Place p = new Place();
                    Console.WriteLine("選んだスポット：{0}",select);
                    //釣れた魚を表示
                    Console.WriteLine("釣れた魚：{0}",p.GetFish(select-1));
                    total += (p.GetFish(select-1).Pt);

                }
                else
                {
                    Console.WriteLine("【エラー】入力値が不正です。再度入力してください");
                    Play();
                }
            }
            Finish();



        }

        private void Start()
        {
            //メッセージ表示＆得点を初期化
            Console.WriteLine("【釣りアプリ】");
            Console.WriteLine("------------------------------");
            Play();

        }

        private void Finish()
        {
            //メッセージ表示＆合計得点表示
            Console.WriteLine("==============================");
            Console.WriteLine("ゲーム終了！合計点は{0}でした", total);


        }


        static void Main(string[] args)
        {
            Game game = new Game(3);
            game.Start();



        }
    }
}
