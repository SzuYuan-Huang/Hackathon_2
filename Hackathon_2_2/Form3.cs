using Hackathon_2_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_2_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefuleModels context = new RefuleModels();
            var list = context.RefuleTable;
            var dataList = list.Where((x) => x.RefuelingDate >= dateTimePicker1.Value && x.RefuelingDate <= dateTimePicker2.Value).ToList();

            dataGridView1.DataSource = dataList;
            double kilometer = 0;
            double l = 0;

            foreach(var d in dataList)
            {
                kilometer += d.Kilometer;
                l += d.Liter;
            }

            label4.Text = (kilometer / l).ToString();
        }
    }
}
