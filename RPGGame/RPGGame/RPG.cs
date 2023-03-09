using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpace
{

    public class RPG : Game, ChoiseChara
    {
  
    enum Select
    {
       Start,
       End
    }

        /// <summary>
        /// 各ゲームのタイトルとルール説明
        /// </summary>
        public override void FirstMessage()
        {
            Console.WriteLine("キャラクターと敵を選んで戦わせよう！");

        }

        /// <summary>
        /// 実行するゲームの内容
        /// </summary>
        public override void PlayGame()
        {    

            Select select = Select.Start;

            switch (select)
            {
                case Select.End:
                    EndMessage(); 
                    break;

                case Select.Start:
                    PlayGame();
                    break;

            }
        }
        public void ChoiseEnemy()
        {
            throw new NotImplementedException();
        }

        public void ChoiseUser()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 結果発表
        /// </summary>
        public override void EndMessage() {
            Console.WriteLine("*** ゲームおわり ***");
        }

    }




}


