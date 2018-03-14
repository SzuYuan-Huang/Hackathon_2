using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2_1
{
    public partial class Form1 : Form
    {
        List<Money> list;
        public Form1()
        {
            InitializeComponent();
            InitialList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal yourMoney = decimal.Parse(textBox1.Text);
            decimal temp1 = 0;
            decimal temp2 = 0;
            decimal differece = 0;
            decimal yourPercent = 0;
            foreach(var l in list)
            {
                if(yourMoney >= l.endRange)
                {
                    temp1 += (l.endRange - l.startRange + 1) * l.percent;
                    temp2 += l.endRange - l.startRange + 1;
                }

                if(yourMoney >= l.startRange && yourMoney <= l.endRange)
                {
                    yourPercent = l.percent;
                }
            }

            differece = yourMoney - temp2;

            label1.Text = (temp1 + differece * yourPercent).ToString();
          
        }

        public void InitialList()
        {
            list = new List<Money>();
            list.Add(new Money { startRange = 1M, endRange = 540000M, percent = 0.05M });
            list.Add(new Money { startRange = 540001M, endRange = 1210000M, percent = 0.12M });
            list.Add(new Money { startRange = 1210001M, endRange = 2420000M, percent = 0.20M });
            list.Add(new Money { startRange = 2420001M, endRange = 4530000M, percent = 0.30M });
            list.Add(new Money { startRange = 4530001M, endRange = 10310000M, percent = 0.40M });
            list.Add(new Money { startRange = 10310000M, endRange = decimal.MaxValue, percent = 0.50M });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 enter = new Form2();
            enter.show(list);
            enter.ShowDialog();
        }
    }

    public class Money
    {
        public decimal startRange { get; set; }
        public decimal endRange { get; set; }
        public decimal percent { get; set; }
    }

}
