using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace GameSpace
{
    public class ILoveCat : LoadGame
    {
        private List<Cat> CatList = new List<Cat>();
        private Random random = new Random();
        static string path = @"C:\Users\ia\Desktop\VisualStudioSourse-main\RPGGame\RPGGame\\catlist.csv";


        public void Load()
        {

            List<Cat> list;

            if (System.IO.File.Exists(path))
            {
                list = LoadFiles(path);
                Console.WriteLine("これまで加わった猫ちゃんも一緒だよ！\n\n");
            }
            else
            {
                //初回時

                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                { }
                list = new List<Cat>();
                Console.WriteLine("はじめての猫探しへ出かけよう！\n\n");
            }
        }
        static List<Cat> LoadFiles(string path)
        {
            List<Cat> list = new List<Cat>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false)
                {
                    string[] values = sr.ReadToEnd().Split(',');
                    //名前の取り出し
                    string name = values[0];
                    string type = values[1];
                    int intimacy = int.Parse(values[2]);
                    Cat c = new Cat(name, type, intimacy);
                    list.Add(c);
                    sr.Close();

                }
            }
            return list;

        }

        public void SaveData(string path,List<Cat> list)
        {
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.UTF8))
            {

                for (int i = 0; i < CatList.Count(); i++)
                {
                    sw.Write(list[i].name);
                    Console.Write(list[i].name);
                    sw.Write(list[i].type);
                    Console.Write(list[i].type);
                    sw.WriteLine(list [i].intimacy);
                    Console.Write(list[i].intimacy);
                }
              /*  foreach (Cat c in list)
                {


                    var txt =c.ToString();
                    sw.WriteLine(txt);

                    //リストの内容をファイル（CSV)に書き込む（上書き）
                    // System.IO.File.WriteAllLines(path, txt, Encoding.GetEncoding("shift-jis"));


                }*/
            }
        }

        public override void FirstMessage()
        {
            Load();
            Console.WriteLine("町の猫ちゃんたちと仲良くなろう！");
            Console.WriteLine("『ねこちゃんダイスキ ゲーム』をはじめる\n\n\n");
        }

        public override void PlayGame()
        {
            List<string> types = new List<string>()
            {
                "三毛猫",
                "スコティッシュフォールド",
                "アビシニアン",
                "はちわれ",
                "黒猫",
                "アメリカンショートヘア",
                "ロシアンブルー"
            };

            while (true)
            {
                Console.WriteLine("1.ねこちゃんを探しにいく　2.知ってるねこちゃんに会いに行く　3.おうちに帰る");
                string select = Console.ReadLine();
                Console.WriteLine("\n\n\n");
                if (int.Parse(select) == 3)
                {
                    EndMessage();
                    break;
                }
                else if (int.Parse(select) == 1)
                {
                    string type = types[random.Next(types.Count)];
                    Console.WriteLine("{0}をみつけた！", type);
                    Console.WriteLine("このねこに名前をつけましょう");
                    string name = Console.ReadLine();
                    Cat cat = new Cat(name, type);
                    Console.WriteLine("{0}が仲間に加わった！", name);
                    CatList.Add(cat);
                }
                else if (int.Parse(select) == 2)
                {
                    if (CatList.Count() == 0)
                    {
                        Console.WriteLine("「まだ1匹もねこを見つけてなかった！」");
                        continue;
                    }

                    int cnt = 1;
                    foreach (Cat ca in CatList)
                    {
                        Console.WriteLine("******{0}匹目******", cnt++);
                        Console.WriteLine(ca.ShowStatus());
                    }

                    Console.WriteLine("-------------------");
                    Console.WriteLine("「さて、どのねこに会いに行こう」");
                    Console.WriteLine("数字を選んでEnter>>");
                    string no = Console.ReadLine();
                    CatList[int.Parse(no) - 1].play();
                    SortCat(CatList);
                }
            }

        }

        static void SortCat(List<Cat> CatList)
        {
            for (int i = 0; i < CatList.Count() - 1; i++)
            {
                for (int j = i + 1; j < CatList.Count(); j++)
                {
                    if (CatList[i].intimacy < CatList[j].intimacy)
                    {
                        Cat temp = CatList[i];
                        CatList[i] = CatList[j];
                        CatList[j] = temp;

                    }

                }

            }

        }




        public override void EndMessage()
        {
            if (CatList.Count() == 0)
            {
                Console.WriteLine("\n\n\n「きょうはおうちにかーえろっと！」");

            }
            else
            {


                Console.WriteLine("\n\n「今日はたくさん遊んだね！そろそろおうちに帰ろう」\n\n");
                Console.WriteLine("「今日みつけたねこ達は、、、」\n\n");
                int cnt = 1;
                foreach (Cat c in CatList)
                {
                    Console.WriteLine("******{0}匹目******", cnt++);
                    Console.WriteLine(c.ShowStatus());
                }
                Console.WriteLine("\n--------------------------------------------\n");
            }
            Console.WriteLine("「また遊んでね！」");
            Console.WriteLine("\n\n***　おしまい　****\n\n");
            SaveData(path, CatList);
            return;


        }

    }

}
