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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefuleTable data = new RefuleTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = (double)numericUpDown1.Value,
                Kilometer = (double)numericUpDown2.Value
            };


            RefuleModels context = new RefuleModels();
            context.RefuleTable.Add(data);
            context.SaveChanges();
            MessageBox.Show("輸入成功");
        }
    }
}
