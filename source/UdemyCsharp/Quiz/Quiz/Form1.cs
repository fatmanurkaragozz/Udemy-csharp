using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int questionNo = 0, truee = 0, falsee = 0;

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonNext.Enabled = false;
            
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionNo++;
            lblQuestionNo.Text = questionNo.ToString();

            if (questionNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kac yilinda ilan edilmistir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }
            if (questionNo == 2)
            {
                richTextBox1.Text = "Hangi il ege bölgemizde bulunmaz?";
                buttonA.Text = "İzmir";
                buttonB.Text = "Balikesir";
                buttonC.Text = "Aydin";
                buttonD.Text = "Manisa";
                label4.Text = "Balikesir";
            }
            if (questionNo == 3)
            {
                richTextBox1.Text = "Son Kuslar hangi yazarimiza aittir?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal Sureya";
                buttonC.Text = "Atilla İlhan";
                buttonD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                buttonNext.Text = "Results";
            }
            if (questionNo == 4)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonNext.Enabled = false;
                MessageBox.Show("True: " + truee + "\n" + "False: " + falsee);

            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNext.Enabled = true;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                lblTrue.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                lblFalse.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNext.Enabled = true;

            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                lblTrue.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                lblFalse.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNext.Enabled = true;

            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                lblTrue.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                lblFalse.Text = falsee.ToString();
                pictureBox2.Visible = true;
            }

        }


        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNext.Enabled = true;

            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                truee++;
                lblTrue.Text = truee.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsee++;
                lblFalse.Text = falsee.ToString();
                pictureBox2.Visible = true;

            }
        }
    }
}
