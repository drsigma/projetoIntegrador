using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Calculadora : Form
    {
        double num1 = -1;
        double num2 = -1;
        string sinal = " ";
       
        public Calculadora()
        {
            InitializeComponent();
            textBox1.Text = "";
            
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(num1 >= 0 && num2 < 0)
            {   
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "+";
            }
            else if (num2 <= 0)
            {

                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "+";
            }
             if (num1 >= 0 && num2 >= 0)
            {
                MessageBox.Show("Clique no Igual e veja o resultado");
                textBox1.Text = Convert.ToString((double)num2);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (num1 >= 0 && num2 < 0)
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "-";
            }
            else if (num2 <= 0)
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "-";

            }
             if (num1 >= 0 && num2 >= 0)
            {
                MessageBox.Show("Clique no Igual e veja o resultado");
                textBox1.Text = Convert.ToString((double)num2);


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (num1 >= 0 && num2 < 0)
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "/";
            }
            else if (num2 <= 0)
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();

                sinal = "/";

            }
             if (num1 >= 0 && num2 >= 0)
            {
                MessageBox.Show("Clique no Igual e veja o resultado");
                textBox1.Text = Convert.ToString((double)num2);

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (num1 >= 0 && num2 < 0)
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "*";
            }
            else if (num2 <= 0)
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "*";

            }
             if (num1 >= 0 && num2 >= 0)
            {
                MessageBox.Show("Clique no Igual e veja o resultado");
                textBox1.Text = Convert.ToString((double)num2);

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = -1;
            num2 = -1;

        }

        private void button15_Click(object sender, EventArgs e)
        {
        
            if (num1 >= 0 && num2 < 0)
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "%";
            }
            else if (num2 <= 0)
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                sinal = "%";


            }
             if (num1 >= 0 && num2 >= 0)
            {
                MessageBox.Show( "Clique no Igual e veja o resultado");
                textBox1.Text = Convert.ToString((double)num2);

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (sinal == " ")
            {
                textBox1.Clear();
                num1 = -1;
                num2 = -1;
                sinal = " ";
            }
            else if ( sinal == "+")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                double conta = (double)num1 + (double)num2;
                textBox1.Text = Convert.ToString((double)conta);
                num1 = -1;
                num2 = -1;
                sinal = " ";
            }
            else if (sinal == "-")
            {

                num2 = Convert.ToDouble(textBox1.Text);

                textBox1.Clear();

                double conta = (double)num1 - (double)num2;
                textBox1.Text = Convert.ToString((double)conta);
                num1 = -1;
                num2 = -1;
                sinal = " ";
            }
            else if (sinal == "/")
            {


                num2 = Convert.ToDouble(textBox1.Text);

                textBox1.Clear();

                double conta = (double)num1 / (double)num2;
                textBox1.Text = Convert.ToString((double)conta);
                num1 = -1;
                num2 = -1;
                sinal = " ";
            }
            else if (sinal == "*")
            {

                num2 = Convert.ToDouble(textBox1.Text);


                textBox1.Clear();

                double conta = (double)num1 * (double)num2;
                textBox1.Text = Convert.ToString((double)conta);
                num1 = -1;
                num2 = -1;
                sinal = " ";
            }
            else if (sinal == "%")
            {

                num2 = Convert.ToDouble(textBox1.Text);


                textBox1.Clear();

                double conta = (double)num1 * ((double)num2 / 100);
                textBox1.Text = Convert.ToString((double)conta);
                num1 = -1;
                num2 = -1;
                sinal = " ";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}
