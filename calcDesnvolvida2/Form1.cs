using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcDesnvolvida2
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            //lblOperacao.Text = Convert.ToString(valor1) + operador + Convert.ToString(valor2) + '=';
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            if(textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                operacao = "SUB";
                operador = '-';
                textBox1.Text = "";
                lblOperacao.Text = Convert.ToString(valor1) + operador;
            }
            else
            {
                textBox1.Text = Convert.ToString('-') ; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                operacao = "MULT";
                operador = 'x';
                textBox1.Text = "";
                lblOperacao.Text = Convert.ToString(valor1) + operador;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                operacao = "DIV";
                operador = '/';
                textBox1.Text = "";
                lblOperacao.Text = Convert.ToString(valor1) + operador;
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                operacao = "SOMA";
                operador = '+';
                textBox1.Text = "";
                lblOperacao.Text = Convert.ToString(valor1) + operador;
            }
            
        }
        private void button16_Click(object sender, EventArgs e)
        {

            if (valor1 > 0) 
            {
                textBox1.Text = '-' + textBox1.Text; 
            }
            else
            {
                textBox1.Text = '+' + textBox1.Text;
            }
            
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
            valor2 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            
            lblOperacao.Text = Convert.ToString(valor1) + operador + Convert.ToString(valor2) + '=';


            switch (operacao)
            {
                case "SOMA":
                    
                    textBox1.Text =Convert.ToString(valor1 + valor2);
                    break;

                case "SUB":
                    textBox1.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "MULT":
                    textBox1.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "DIV":
                    textBox1.Text = Convert.ToString(valor1 / valor2);
                    break;
                case "PORC":
                    textBox1.Text = Convert.ToString(valor1 / 100);
                    break;
            }
        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor1 = 0;
            valor2 = 0;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }
    }
}
