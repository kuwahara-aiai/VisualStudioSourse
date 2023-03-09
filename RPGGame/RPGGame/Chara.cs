using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpace
{


    public abstract class Chara
    {
        protected string name="山田太郎";
        protected int hp=50;
        protected int mp=50;
        protected string decisiveline="この国の王になる！";

        public string Name { get; }
        public abstract int Hp { get; }
        public abstract int Mp { get; }
        public abstract string Decisiveline { get; }


        /// <summary>
        /// 戦う
        /// </summary>
        public abstract void Fight();
        /// <summary>
        /// 逃げる
        /// </summary>
        public abstract void Run();
        /// <summary>
        /// アイテム
        /// </summary>
        public void Item() {
            string[] items = new string[3]  {"ポーション","薬草","爆弾"};

        }
    }
    public class Brave : Chara,PhysicalAttack
    {
        public Brave() { }
        public override int Hp { get { return hp + 300; } }

        public override int Mp { get { return 0; } }
        public override string Decisiveline { get { return "ぶった切ってやるぜ！！"; } }


        public override void Fight()
        { }
        public void Kick()
        {
            throw new NotImplementedException();
        }

        public void Punch()
        {
            throw new NotImplementedException();
        }
        public void Skill()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 攻撃
        /// </summary>
        public override void Run() 
        { }

     

        /// <summary>
        /// 逃げる
        /// </summary>

    }

    public class Wizard : Chara, Magic
    {
        public Wizard() { }
        public override int Hp { get { return hp + 100; } }

        public override int Mp { get { return mp + 200; } }
        public override string Decisiveline { get { return "私の炎で焼き尽くしてあげましょう"; } }


        public override void Fight() { }
        /// <summary>
        /// 攻撃
        /// </summary>
        public override void Run() { }
        /// <summary>
        /// 逃げる
        /// </summary>
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


