using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    public class Place
    {
        FishList fl = new FishList();
        //釣り場のリスト
        public List<Fish> pbox = new List<Fish>();

        public Place()
        {

            //placeに5つ分のFishを挿入する
            for(int i = 0; i < 5; i++)
            {
                pbox.Add(fl.RandomFish());
            }
            
 
        }

        public Fish GetFish(int index)
        {
            //FishList(pbox?)のindex番号目のFishを取得する
            return pbox[index];
        }

        public int NumOfPlaces()
        { 
            //pboxの数を取得する
            return pbox.Count;
        }
        public static void Test()
        {

            Place p1 = new Place();

            Console.WriteLine("場所の数:" + p1.NumOfPlaces());
            for(int i = 0; i < p1.NumOfPlaces(); i++)
            {
                Console.WriteLine(p1.GetFish(i));
            }
        }
    }
}
