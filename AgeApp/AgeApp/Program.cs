abstract class Person
{
    protected string name;
    protected int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name { get { return this.name; } }
    public abstract int Age { get; } // 抽象メソッドには定義は要らない
}

/// <summary>
/// 正直者。
/// 年齢を偽らない。
/// </summary>
class Truepenny : Person
{
    public Truepenny(string name, int age) : base(name, age) { }

    public override int Age
    {
        get
        {
            // 実年齢をそのまま返す。
            return this.age;
        }
    }
}

/// <summary>
/// 嘘つき。
/// 鯖を読む(しかも、歳取るにつれ大幅に)。
/// </summary>
class Liar : Person
{
    public Liar(string name, int age) : base(name, age) { }

    public override int Age
    {
        get
        {
            // 年齢を偽る。
            if (this.age < 20) return this.age;
            if (this.age < 25) return this.age - 1;
            if (this.age < 30) return this.age - 2;
            if (this.age < 35) return this.age - 3;
            if (this.age < 40) return this.age - 4;
            return this.age - 5;
        }
    }
}

/// <summary>
/// いいかげん。
/// 大体の歳しか答えない。
/// </summary>
class Equivocator : Person
{
    public Equivocator(string name, int age) : base(name, age) { }

    public override int Age
    {
        get
        {
            // 年齢を四捨五入した値を返す。
            return ((this.age + 5) / 10) * 10;
        }
    }
}

/// <summary>
/// いくつになったって気持ちは17歳。
/// </summary>
class Seventeenist : Person
{
    public Seventeenist(string name, int age) : base(name, age) { }

    public override int Age
    {
        get
        {
            // 「おいおい」って突っ込み入れてあげてね。
            return 17;
        }
    }
}

class PolymorphismTest
{
    static void Main()
    {
        //それぞれのインスタンスでIntroduceメソッド呼び出し
        Introduce(new Truepenny("正直　太郎", 52)); //正直者の太郎さん。
        Introduce(new Liar("鯖読　花子", 52)); //嘘つきの花子さん。
        Introduce(new Equivocator("適当　順次", 52)); //いい加減な順次さん。
        Introduce(new Seventeenist("若狭　永遠", 52)); // 時空を超える永遠さん。
        Truepenny t = new Truepenny("山田花子", 11);
        Console.Write("私の名前は、{0}。\n", t.Name);
        Console.Write("私は {0} 歳です。\n\n", t.Age);

    }

    /// <summary>
    /// p さんの自己紹介をする。
    /// </summary>
    static void Introduce(Person p)
    {
        Console.Write("私の名前は、{0}。\n", p.Name);
        Console.Write("私は {0} 歳です。\n\n", p.Age);
    }
}