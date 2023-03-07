using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Game
    {
        protected string gameTitle;

        /// <summary>
        /// 各ゲームのタイトルとルール説明
        /// </summary>
        public  void TitleCall(string gameTitle)
        {
            Console.WriteLine(gameTitle+"を始めるよ");
        }
        /// <summary>
        /// 実行するゲームの内容
        /// </summary>
        public abstract void Play();
        /// <summary>
        /// 結果発表
        /// </summary>
        public void GameResult(string gameTitle)
        {
            Console.WriteLine(gameTitle + "終了するよ");
        }



    }
}
