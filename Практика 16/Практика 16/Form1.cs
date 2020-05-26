using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        string text1 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            string ei;
            text1 = textBox1.Text;
            try
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text[i] != '0' && textBox1.Text[i] != '1' && textBox1.Text[i] != '-') { throw new Exception(": Вы ввели не двоичное число"); }
                }
                Class1 obj = new Class1(((int)Math.Abs(Convert.ToInt32(textBox1.Text))));
                if (radioButton2.Checked == true)
                {
                    n = obj.convert_to_ten(textBox1.Text, textBox1.Text.Length);
                    textBox2.Text = "Число " + textBox1.Text + " в десятичном виде = " + n;
                }
                if (radioButton1.Checked == true)
                {
                    n = (int)Math.Abs(obj.convert_to_ten(textBox1.Text, textBox1.Text.Length));
                    textBox2.Text = "Число " + textBox1.Text + " в 8 системе счисления = " + obj.convert_to_eight(n, textBox1.Text, textBox1.Text.Length);
                }
                if (radioButton3.Checked == true)
                {
                    n = obj.convert_to_ten( textBox1.Text, textBox1.Text.Length);
                    ei = obj.convert_to_six(n, textBox1.Text);
                    textBox2.Text = "Число " + textBox1.Text + " в 16 системе счисления = " + ei;
                }
            }
            catch (Exception err)
            {
                textBox2.Text = "Неправильный формат ввода " + err.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text1 != textBox1.Text) { textBox2.Text = ""; text1 = textBox1.Text; }
        }
    }   
}
