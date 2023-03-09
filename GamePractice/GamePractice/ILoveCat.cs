using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePractice
{
    public class ILoveCat : Game
    {
        private List<Cat> CatList = new List<Cat>();
        private Random random = new Random();


        public override void FirstMessage()
        {
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

                    int cnt=1;
                    foreach (Cat ca in CatList)
                    {
                        Console.WriteLine("***  {0}匹目 ***　",cnt++);
                        Console.WriteLine(ca.ShowStatus());
                    }
                    
                    /*
                      * int c = 1;
                    for (int i = 0; i < CatList.Count(); i++)
                    {
                        Console.Write("{0}匹目　　", c++);
                        Console.Write("名前：{0}  ", CatList[i].name);
                        Console.Write("種類：{0}  ", CatList[i].type);
                        Console.WriteLine("親密度：{0}", CatList[i].intimacy);

                    }*/
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
            Console.WriteLine("\n\n「今日はたくさん遊んだね！そろそろおうちに帰ろう」\n\n");
            Console.WriteLine("「今日みつけたねこ達は、、、」\n\n");
            int cnt = 1;
            foreach (Cat c in CatList)
            {
                Console.WriteLine("***  {0}匹目 ***　", cnt++);
                Console.WriteLine(c.ShowStatus());
            }
            Console.WriteLine("「また遊んでね。おしまい。\n\n\n」");
            return;

        }
    }
    public class Cat
    {
        private string s_name;
        private string s_type;
        private int i_intimacy;

        public string name { get { return s_name; } set { s_name = value; } }
        public string type { get { return s_type; } set { s_type = value; } }
        public int intimacy { get { return i_intimacy; } set { i_intimacy = value; }    }

        /*        public string Name
                {
                    get { return Name; } // getterの部分
                    set { Name = value; } // setterの部分
                }
                public string Type
                {
                    get { return Type; } // getterの部分
                    set { Type = value; } // setterの部分
                }
                public int Intimacy
                {
                    get { return Intimacy; } // getterの部分
                    set { Intimacy = value; } // setterの部分
                }*/
        public Cat(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string ShowStatus()
        {

            return string.Format("{0:G}の{1:G}、親密度は{2:D}ポイント！\n", this.type, this.name, this.intimacy);

        }

        public void play()
        {
            Console.WriteLine("{0}と遊んだ\n{0}との親密度がアップした！", this.name);
            this.intimacy++;
        }

    }
}
