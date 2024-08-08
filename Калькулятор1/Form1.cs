using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Калькулятор1
{
    public partial class Form1 : Form
       
    {
        float result,summ;
        string oper,num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text+'1';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }

        private void button12_Click(object sender, EventArgs e)
        {
         
            textBox1.Text = textBox1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                result = Convert.ToSingle(textBox1.Text);
                textBox1.Text = "";
            }
            oper = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
         
            if (textBox1.Text != "")
            {
            result = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "";
            }
            oper = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                result = Convert.ToSingle(textBox1.Text);
                textBox1.Text = "";
            }
            oper = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                result = Convert.ToSingle(textBox1.Text);
                textBox1.Text = "";
            }
            oper = "*";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==true)
            {
                
                this.BackColor = Color.Black;
                checkBox1.Text = "Светлая тема";
                checkBox1.ForeColor = Color.White;
            } else
            {
                this.BackColor = Color.White;
                checkBox1.Text = "Темная тема";
                checkBox1.ForeColor = Color.Black;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            summ = 0;
            if ( oper == "+") 
            {
                num = textBox1.Text;
                summ = result+float.Parse(textBox1.Text) ;
                textBox1.Text = Convert.ToString(summ);
                textBox2.Text = textBox2.Text+  result+oper +num + '='+Convert.ToString(summ)+'\r' + '\n';
            }
            if (oper == "-")
            {
                num = textBox1.Text;
                summ = result - float.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(summ);
                textBox2.Text = textBox2.Text + result + oper + num + '=' + Convert.ToString(summ) + '\r' + '\n';
            }
            if (oper == "*")
            {
                num = textBox1.Text;
                summ = result * float.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(summ);
                textBox2.Text = textBox2.Text + result + oper + num + '=' + Convert.ToString(summ) + '\r' + '\n';
            }
            if (oper == "/")
            {

                num = textBox1.Text;
                if (float.Parse(textBox1.Text) == 0)
                {
                    MessageBox.Show("Делить на 0 нельзя!", "Внимание!");
                        
                    
                }else { 
                summ = result / float.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(summ);
                textBox2.Text = textBox2.Text + result + oper + num + '=' + Convert.ToString(summ) + '\r' + '\n';
            }
            }

        }
    }
}
