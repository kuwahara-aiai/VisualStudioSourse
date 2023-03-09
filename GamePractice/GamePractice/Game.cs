using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice
{
    public abstract class Game
    {
        protected string gameTitle;

        /// <summary>
        /// 各ゲームのタイトルとルール説明
        /// </summary>
        public abstract void FirstMessage();
        /// <summary>
        /// 実行するゲームの内容
        /// </summary>
        public abstract void PlayGame();
        /// <summary>
        /// 結果発表
        /// </summary>
        public abstract void EndMessage();


    }
}
