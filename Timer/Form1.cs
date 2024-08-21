using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int clicked = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            clicked++;
            for (clicked = 1; clicked >= 0;)
            {
                MessageBox.Show("10");
                MessageBox.Show("9");
                MessageBox.Show("8");
                MessageBox.Show("7");
                MessageBox.Show("6");
                MessageBox.Show("5");
                MessageBox.Show("4");
                MessageBox.Show("3");
                MessageBox.Show("2");
                MessageBox.Show("1");
                break;
            }
        }
    }
}
