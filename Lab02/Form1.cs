using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        private bool calcStatus;
        private ArrayList calcHistoryList = new ArrayList();
        private int historyListIndex = 0;
        private string calcText;
        private float calcTextAsNum;

        public Form1()
        {
            InitializeComponent();
            calcStatus = false;
        }

        /// <summary>
        /// Loops through every button in every container and sets the button property, Enabled,
        /// depending on the parameter given
        /// </summary>
        /// <param name="status"></param>
        private void turnOnCalculator(bool status)
        {
            foreach (Control control in mButtonsContainer.Controls) 
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            foreach (Control control in calcNumberContainer.Controls) 
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            foreach (Control control in calcOperatorContainer.Controls) 
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            foreach (Control control in calcControlContainer.Controls) 
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
        }

        /// <summary>
        /// negates instance variable calcStatus and calls turnOnCalculator function with
        /// calcStatus as the parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcOnButton_Click(object sender, EventArgs e)
        {
            calcStatus = !calcStatus;
            turnOnCalculator(calcStatus);
            calcOnButton.Text = calcStatus ? "Off" : "On";
            calcText = "0";
            calcTextAsNum = 0;
            calcValue.Text = calcText;
        }

        /// <summary>
        /// inputs the desired number into the calculator
        /// </summary>
        /// <param name="buttonNumber"></param>
        private void numberButtonClick(string buttonNumber)
        {
            bool isZero = calcText == "0";
            bool containsDecimal = calcText.Contains(".");
            // if the input is not just zero or contains a decimal, continue to concatenate the number at the end
            if (!isZero || containsDecimal)
            {
                calcText += buttonNumber;
            }
            else
            {
                calcText = buttonNumber;
            }
            calcTextAsNum = float.Parse(calcText);
            calcValue.Text = calcText;
        }

        // bug fix to be made
        // currently adding is a bit of an issue as some logic errors
        // what i should do is make a seperate function for returning the result
        // two ways i could get result
        // 1. i use = button
        // 2. i use another operator button
        // think about it carefully ty
        private void doOperation(string operation)
        {
            if (historyListIndex == 0)
            {
                calcHistoryList.Add(calcTextAsNum);
                calcText = "0";
                calcTextAsNum = 0;
                historyListIndex++;
            }
            else
            {
                calcHistoryList.Add(calcTextAsNum);
                float operandOne = (float)calcHistoryList[0];
                float operandTwo = (float)calcHistoryList[1];
                switch (operation) 
                {
                    case "add":
                        calcTextAsNum = operandOne + operandTwo;
                        calcHistoryList.Add(calcTextAsNum);
                        calcText = calcTextAsNum.ToString();
                        break;
                }
                calcHistoryList.Remove(operandOne);
                calcHistoryList.Remove(operandTwo);
                historyListIndex--;
            }
            Console.WriteLine(calcHistoryList[0]);
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            bool text_status = calcValue.Text == "0";
            if (!text_status || calcValue.Text.Contains("."))
            {
                calcText += "0";
                calcValue.Text = calcText;
            }
        }
        private void buttonDeciamlPoint_Click(object sender, EventArgs e)
        {
            bool text_status = calcValue.Text.Contains('.');
            if (!text_status)
            {
                calcText += ".";
                calcValue.Text += ".";
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            numberButtonClick("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            numberButtonClick("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            numberButtonClick("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            numberButtonClick("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            numberButtonClick("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            numberButtonClick("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            numberButtonClick("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            numberButtonClick("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            numberButtonClick("9");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            doOperation("add");
        }
    }
}
