using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{


    public abstract class Chara
    {
        protected int attack;
        protected string name;
        protected int hp;
        protected int mp;
        protected string decisiveline;

        public Chara(int attack, string name, int hp, int mp, string decisiveline)
        {
            this.attack = attack;
            this.name = name;
            this.hp = hp;
            this.mp = mp;
            this.decisiveline = decisiveline;
        }
        public abstract int Attack { get; } // 抽象メソッドには定義は要らない
        public string Name { get { return this.name; } }
        public abstract int Hp { get; }
        public abstract int Mp { get; }
        public abstract string Decisiveline { get; }

        /*
                /// <summary>
                /// 自己紹介
                /// </summary>
                public abstract void Introduction(string job,string name);
                /// <summary>
                /// 攻撃
                /// </summary>
                public abstract void Attack(string job);
                /// <summary>
                /// 逃げる
                /// </summary>
                public abstract void Run_away();*/
    }
    public class Brave : Chara
    {
        public Brave(int attack, string name, int hp, int mp, string decisiveline) : base(attack, name, hp, mp, decisiveline) { }

        public override int Attack { get { return this.attack + 30; } }
        public override int Hp { get { return this.hp + 300; } }

        public override int Mp { get { return 0; } }
        public override string Decisiveline { get { return "ぶった切ってやるぜ！！"; } }
    }

    public class Wizard : Chara, Magic
    {
        public Wizard(int attack, string name, int hp, int mp, string decisiveline) : base(attack, name, hp, mp, decisiveline) { }

        public override int Attack { get { return this.attack; } }
        public override int Hp { get { return this.hp; } }

        public override int Mp { get { return this.mp + 300; } }
        public override string Decisiveline { get { return "私の魔法で焼き尽くしてあげましょう"; } }

        public void Heal()
        {
            Console.WriteLine("回復魔法！");
        }

        public void MagicAttack()
        {
            Console.WriteLine("言いたいことも言えないこんな世の中じゃ！！ポイズン！！");
        }
    }
}


