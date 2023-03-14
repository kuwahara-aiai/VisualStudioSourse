using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void myHand_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int myHandNum = rnd.Next(0, 2);
            int pcHandNum = rnd.Next(0, 2);
            List<string> rsp = new List<string>();
            rsp.Add(@"C:\\Users\\ia\\Desktop\\img\\paper.png"); //パー
            rsp.Add(@"C:\\Users\\ia\\Desktop\\img\\rock.png");　//チョキ
            rsp.Add(@"C:\\Users\\ia\\Desktop\\img\\scissors.png"); //グー

            MyHand.ImageLocation = rsp[myHandNum];
            PcHand.ImageLocation = rsp[pcHandNum];

            var judgement = new int[,]

            {
                {0,1,2},
                {2,0,1},
                {1,2,0},
            };

            if (judgement[myHandNum, pcHandNum] == 0)
            {
                judge.Text = "あいこ";
            }
            else if (judgement[myHandNum, pcHandNum] == 1)
            {
                judge.Text = "負け";
            }
            else
            {
                judge.Text = "勝ち";
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void MyHund_Click(object sender, EventArgs e)
        {

        }
    }
}
