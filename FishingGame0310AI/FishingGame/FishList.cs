using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    public class FishList
    {
        private Random rnd = new Random();
        private List<Fish> box = new List<Fish>();
        public FishList()
        {

            box.Add(new Fish("マグロ", 100));
            box.Add(new Fish("タイ", 120));
            box.Add(new Fish("サケ", 80));
            box.Add(new Fish("ブリ", 70));
            box.Add(new Fish("イカ", 30));
            box.Add(new Fish("ホタテ", 20));
            box.Add(new Fish("アジ", 15));
            box.Add(new Fish("メダカ", 3));
            box.Add(new Fish("ゴミ", 0));
            box.Add(new Fish("おじさん", -50));


        }
        public Fish RandomFish()
        {
            return box[rnd.Next(box.Count)];
        }
        public static void RandTest(int n)
        {
            FishList fl = new FishList();
            Fish fish = new Fish();

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(fl.RandomFish());


            }
        }

    }
}
