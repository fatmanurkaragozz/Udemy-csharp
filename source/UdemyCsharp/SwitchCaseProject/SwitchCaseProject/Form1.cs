using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCaseProject
{
    public partial class Form1 : Form
    {
        private int clickCounter = 0; // Counter that tracks click counter

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickCounter++; // The counter is incremented with each button click

                try
                {
                    int number1 = Convert.ToInt16(textBox1.Text);
                    int number2 = Convert.ToInt16(textBox2.Text);
                    char operatorr = Convert.ToChar(textBox3.Text);

                    switch (operatorr)
                    {
                        case '+':
                            textBox4.Text = (number1 + number2).ToString();
                            break;
                        case '-':
                            textBox4.Text = Math.Abs(number1 - number2).ToString();
                            break;
                        case '*':
                            textBox4.Text = (number1 * number2).ToString();
                            break;
                        case '/':
                            textBox4.Text = (number1 / number2).ToString();
                            break;
                        default:
                            MessageBox.Show("You entered an invalid operator");
                            break;
                    }
                
                // Clear TextBoxes only on every second click
                if (clickCounter % 2 == 0)
                {
                    ClearTextBoxes();
                }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Please in enter valid number !");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The number in enter very big or very small !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred" + ex.Message);
                }

            
          
        }

        // Method in the delete all textboxs
        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
