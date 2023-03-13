using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpace
{
    public class Main1
    {
        static void Main(string[] args)
        {
            /*            ILoveCat catgame = new ILoveCat();
                        catgame.FirstMessage();
                        catgame.PlayGame();*/

            ILoveCat c = new ILoveCat();
            string path = @"C:\Users\ia\Desktop\VisualStudioSourse-main\RPGGame\RPGGame\\catlist.csv";

            List<Cat> cat = new List<Cat>();
            cat.Add(new Cat("ボス次郎", "ボス猫",30));
            cat.Add(new Cat("山太郎", "ドラ猫",20));
            cat.Add(new Cat("モテ三郎", "ロシアンブルー",10));
            foreach (Cat cat2 in cat)
            {
                Console.WriteLine("《　{0}の{1}　》　親密度：{2}", cat2.type,cat2.name,cat2.intimacy);
            }
            c.SaveData(path,cat);

        }
    }


}
