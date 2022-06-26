using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculardoraform
{
    public partial class Form1 : Form
    {
        Stack<float> numbers = new Stack<float>();
        public Form1()
        {
            InitializeComponent();
        }
        private void addNumber(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if ((textResult.Text == "0" || textResult.Text == "")&& boton.Text == ",")
                textResult.Text = "0,";
            else
            {
                
                textResult.TextAlign = HorizontalAlignment.Left;
                textResult.Text += boton.Text;
             }


        }

        private float getFirst()
        {
            string minumero = textResult.Text;
            string[] strings = minumero.Split(Environment.NewLine,
                            StringSplitOptions.RemoveEmptyEntries);
            float result = float.Parse(strings[0]);
            return result;
        }
        private void Enter(object sender,EventArgs e) {

            numbers.Push(getFirst());
            textResult.Text += "\r\n";
            textResult.TextAlign = HorizontalAlignment.Right;

        }
        private void addition(object sender,EventArgs e)
        {   if (numbers.Count >= 2)
            {
                float operand1 = numbers.Pop();
                float operand2 = numbers.Pop();
            }
            else
            {
                textResult.Text = "Too few arguments";
            }
            int i = 0;
        
        }
        private void deleteTwo()
        {
            String result = textResult.Text;
            string[] strings = result.Split(Environment.NewLine,
                            StringSplitOptions.RemoveEmptyEntries);
            String first = strings[0];
            result.Replace(first + "\r\n", "");
            String second = strings[1];
            result.Replace(second + "\r\n", "");
            textResult.Text = result;

        }
        private void substraction(object sender,EventArgs e)
        {
            if (numbers.Count >= 2)
            {
                float operand1 = numbers.Pop();
                float opeand2 = numbers.Pop();
            }
            else
            {
                textResult.Text = "Too few arguments";
            }
        }

        private void multiplication(object sender,EventArgs e)
        {
            if (numbers.Count >= 2)
            {
                float operand1 = numbers.Pop();
                float opeand2 = numbers.Pop();
            }
            else
            {
                textResult.Text = "Too few arguments";
            }

        }

        private void divide(object sender, EventArgs e)
        {
            if (numbers.Count >= 2)
            {
                float operand1 = numbers.Pop();
                float opeand2 = numbers.Pop();
            }
            else
            {
                textResult.Text = "Too few arguments";
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }
    }
}