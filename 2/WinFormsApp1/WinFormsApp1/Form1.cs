using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0" ;
            textBox2.ReadOnly = true;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double rubtousd = 76.32;
            double rubtoeur = 87.15;
            double usdtoeur = 0.87; 
            double eurtousd = 1.14;

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                double to = rubtousd * Convert.ToInt32(textBox1.Text);
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                double to = rubtoeur * Convert.ToInt32(textBox1.Text);
                textBox2.Text = to.ToString();
            }
            //
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                double to = Convert.ToInt32(textBox1.Text)/ rubtousd;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                double to = Convert.ToInt32(textBox1.Text) / usdtoeur;
                textBox2.Text = to.ToString();
            }
            //
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                double to =Convert.ToInt32(textBox1.Text) / rubtoeur;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                double to = Convert.ToInt32(textBox1.Text) * eurtousd;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                textBox2.Text = textBox1.Text.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double rubtousd = 76.32;
            double rubtoeur = 87.15;
            double usdtoeur = 0.87;
            double eurtousd = 1.14;

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                double to = rubtousd * Convert.ToInt32(textBox1.Text);
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                double to = rubtoeur * Convert.ToInt32(textBox1.Text);
                textBox2.Text = to.ToString();
            }
            //
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                double to = Convert.ToInt32(textBox1.Text) / rubtousd;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                double to = Convert.ToInt32(textBox1.Text) / usdtoeur;
                textBox2.Text = to.ToString();
            }
            //
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                double to = Convert.ToInt32(textBox1.Text) / rubtoeur;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                double to = Convert.ToInt32(textBox1.Text) * eurtousd;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double rubtousd = 76.32;
            double rubtoeur = 87.15;
            double usdtoeur = 0.87;
            double eurtousd = 1.14;

            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                double to = rubtousd * Convert.ToInt32(textBox1.Text);
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                double to = rubtoeur * Convert.ToInt32(textBox1.Text);
                textBox2.Text = to.ToString();
            }
            //
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                double to = Convert.ToInt32(textBox1.Text) / rubtousd;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                double to = Convert.ToInt32(textBox1.Text) / usdtoeur;
                textBox2.Text = to.ToString();
            }
            //
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                double to = Convert.ToInt32(textBox1.Text) / rubtoeur;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                double to = Convert.ToInt32(textBox1.Text) * eurtousd;
                textBox2.Text = to.ToString();
            }
            if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 2)
            {
                textBox2.Text = textBox1.Text.ToString();
            }
        }
    }
}
