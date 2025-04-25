using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private decimal firstNum = 0.0m;
        private decimal secondNum = 0.0m;
        private decimal result = 0.0m;
        private int opratorType = (int)MathOperations.NoOperator;


        public enum MathOperations
        {
            NoOperator = 0,
            Addition = 1,
            Subtraction = 2,
            Division = 3,
            Multiplication = 4,
            Percentage = 5
        }


        private void DigitBtn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }

            DisplayTextBox.Text += btn.Text;

        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains("."))
            {
                DisplayTextBox.Text += ".";
            }
            
        }

        private void PluminusButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('-'))
            {
                DisplayTextBox.Text = "-" + DisplayTextBox.Text;
            }
            else
            {
                DisplayTextBox.Text = DisplayTextBox.Text.Trim('-');
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Addition);
        }

        private void SaveValueAndOperatorType(int operation)
        {
            opratorType = operation;
            firstNum = Convert.ToDecimal(DisplayTextBox.Text);
            DisplayTextBox.Text = "0";

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Subtraction);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Division);
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiplication);
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Percentage);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDecimal(DisplayTextBox.Text);

            switch (opratorType)
            {
                case (int)MathOperations.Addition:
                    result = firstNum + secondNum;
                    break;
                case (int)MathOperations.Subtraction:
                    result = firstNum - secondNum;
                    break;
                case (int)MathOperations.Division:
                    result = firstNum / secondNum;
                    break;
                case (int)MathOperations.Multiplication:
                    result = firstNum * secondNum;
                    break;
                case (int)MathOperations.Percentage:
                    result = (firstNum / secondNum) * 100;
                    break;
            }

            DisplayTextBox.Text = result.ToString();
        }

        private void ClearEraseButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            firstNum = 0.0m;
            secondNum = 0.0m;
            result = 0.0m;
            opratorType = (int)MathOperations.NoOperator;
    }
    }

}

