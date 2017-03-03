using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatLib;


namespace avtomat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool is_number = Mashina.Match(textBox1.Text);
            label1.Text = is_number.ToString();
            if (is_number)
            {
                pictureBox1.Image = avtomat.Properties.Resources.галочка;
            }
            else 
            {
                pictureBox1.Image = avtomat.Properties.Resources.xx;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1_Click(null,null);
            }
        }
    }
}
