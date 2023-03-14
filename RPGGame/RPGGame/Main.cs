using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpace
{
    public class Main1
    {
        static void Main(string[] args)
        {
            ILoveCat catgame= new ILoveCat();
            catgame.FirstMessage();
            catgame.PlayGame();
        }
    }
}
