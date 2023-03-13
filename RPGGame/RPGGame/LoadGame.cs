using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameSpace
{
    public abstract class LoadGame:LoadData
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

        public void LoadData()
        {
            throw new NotImplementedException();
        }

        public void SaveData(string path)
        {
            throw new NotImplementedException();
        }

        public void SaveData(string path, List<Cat> list)
        {
            throw new NotImplementedException();
        }
    }
}
