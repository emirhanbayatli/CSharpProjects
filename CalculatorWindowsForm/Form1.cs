using CalculatorWindowsForm.Classes;
using System;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firstNumber;
        double secondNumber;
        double result;

        IOperation selectedOperation;

        Addition addition = new Addition();
        Division division = new Division();
        Multiplication multiplication = new Multiplication();
        Subtraction subtraction = new Subtraction();


        public void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }



        public void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            double currentNumber = double.Parse(textBox1.Text);

            if (selectedOperation != null)
            {
                firstNumber = selectedOperation.Calculate(firstNumber, currentNumber);
            }
            else
            {
                firstNumber = currentNumber;
            }

            switch (button.Text)
            {
                case "+":
                    selectedOperation = addition;

                    break;
                case "-":
                    selectedOperation = subtraction;

                    break;
                case "X":
                    selectedOperation = multiplication;

                    break;
                case "/":
                    selectedOperation = division;

                    break;
                default:
                    MessageBox.Show("Gecersiz bir Islem denediniz lutfen tekrar deneyin.");
                    break;
            }
            textBox1.Text = "";
        }

        public void Equality_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (selectedOperation == null)
            {
                MessageBox.Show("Gecersiz bir Islem denediniz lutfen tekrar deneyin.");
                return;
            }


            secondNumber = double.Parse(textBox1.Text);

            if (selectedOperation == division)
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Bolme isleminde bolunen sayi 0 olamaz!");
                    return;
                }
            }


            result = selectedOperation.Calculate(firstNumber, secondNumber);

            firstNumber = result;
            selectedOperation = null;

            textBox1.Text = result.ToString();

        }

        public void EmptyBtn_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            textBox1.Text = "";
        }
    }
}
