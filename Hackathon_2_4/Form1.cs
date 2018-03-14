using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInformation();
        }

        public void LoadInformation()
        {
            label1.Text = "中華電信 月租費350元 每分鐘4元" +
                Environment.NewLine + "遠傳 月租費400元 每分鐘3元" +
                Environment.NewLine + "台灣大哥大 月租費500元 每分鐘2元";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minute = int.Parse(textBox1.Text);
            Dictionary<string, int> detail = new Dictionary<string, int>();
            detail.Add("中華電信",350 + 4 * minute);
            detail.Add("遠傳", 400 + 3 * minute);
            detail.Add("台灣大哥大", 500 + 2 * minute);

            var min = detail.Min((x) => x.Value);
            var who = detail.Where((x) => x.Value == min);
            string temp = "划算的店家：";
            foreach(var w in who)
            {
                temp += w.Key + " ";
            }

            label2.Text = temp;
        }
    }
}
