using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTelling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fortune_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(0, 6);
            string[] fortunes = { "大凶", "凶", "小吉", "中吉", "吉", "大吉" };
            string[] text = { "アチャー！\r\nでも、明日はきっと大吉！", "帰り道に気を付けて、、、！",
                "明日はもっといい日！", "まあまあってな感じの日だな！", "やったね、\r\n一番ちょうどいい！",
                "おめでとー！\r\n周りの人にも幸運をおすそわけだ！" };
            kuji.Text = fortunes[num];
            label.Text = text[num];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
