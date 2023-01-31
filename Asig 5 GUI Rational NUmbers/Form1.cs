// Fabian Echevarria Rational Number GUI
using System;
using System.Windows.Forms;


namespace Asig5_Rational_GUI
{
    public partial class Form1 : Form
    {

        private int RationalA;
        private int RationalB;
        private int Result;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Rational 1
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Rational 2
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Rational textBox 1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Rational textBox 2
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Addition button
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Substract button
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Multiplication button
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Division button
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get result
            try
            {
                // Parse the input rational numbers
                RationalNumber r1 = RationalNumber.Parse(textBox1.Text);
                RationalNumber r2 = RationalNumber.Parse(textBox2.Text);
    
                // Check which operation was selected
                if (radioButton1.Checked)
                {
                    // Addition
                    RationalNumber result =  r1.Sum(r2); ;
                    textBox3.Text = result.ToString();
                }
                else if (radioButton2.Checked)
                {
                    // Subtraction
                    RationalNumber result = r1.Substract(r2);
                    textBox3.Text = result.ToString();
                }
                else if (radioButton3.Checked)
                {
                    // Multiplication
                    RationalNumber result = r1.Multiply(r2);
                    textBox3.Text = result.ToString();
                }
                else if (radioButton4.Checked)
                {
                    // Division
                    RationalNumber result = r1.Division(r2);
                    textBox3.Text = result.ToString();
                }
                else
                {
                    // No operation was selected, display an error message
                    MessageBox.Show("Please select an operation", "Error");
                }

            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
           
        }
    }
}