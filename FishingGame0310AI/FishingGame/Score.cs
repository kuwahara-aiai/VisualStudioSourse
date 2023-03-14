using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FishingGame
{
    public class Score
    {
        private DateTime _updateTime;
        private int _score;

        public DateTime updateTime { get { return _updateTime; } set { _updateTime = value; } }  
        public  int score { get { return _score; } set { _score = value; } }

        public Score()
        {
        }
        public Score(DateTime updateTime, int score)
        {
            this.updateTime = updateTime;
            this.score = score;

        }
    }
}
