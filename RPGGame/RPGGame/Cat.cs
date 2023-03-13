using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameSpace
{
    public class Cat
    {
        private string s_name;
        private string s_type;
        private int i_intimacy;

        public string name { get { return s_name; } set { s_name = value; } }
        public string type { get { return s_type; } set { s_type = value; } }
        public int intimacy { get { return i_intimacy; } set { i_intimacy = value; } }


        public Cat(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public Cat(string name, string type, int intimacy)
        {
            this.name = name;
            this.type = type;
            this.intimacy = intimacy;

        }


        public string ShowStatus()
        {

            return string.Format("{0:G}の『{1:G}』\n親密度は{2:D}ポイント！\n", this.type, this.name, this.intimacy);

        }

        public void play()
        {
            Console.WriteLine("{0}と遊んだ\n{0}との親密度がアップした！", this.name);
            this.intimacy++;
        }

    }
}
