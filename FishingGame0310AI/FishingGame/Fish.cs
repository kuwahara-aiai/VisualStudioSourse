using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    public class Fish
    {
        private string name;
        private int pt;

        public int Pt { get { return pt; } }   

        public Fish()
        {
            name = "無名の魚";
            pt = 10;


         }
        public Fish(string name, int pt)
        {
            this.name = name;
            this.pt = pt;
        }
        public override string ToString()
        {

            return String.Format("{0}({1}pt)", name, pt);

        }
    }
}
