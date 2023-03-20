namespace DesktopCalculator
{
    public partial class Form1 : Form
    {

        //variables
        private string tempNum;
        private string rightEq;
        private string leftEq;
        private double rightNum;
        private double leftNum;
        private string tempOp;
        private string calc = "=";



        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------EVENT HANDLERS----------------------------------//
        private void NumBtnClicked(object sender, EventArgs e)
        {
            //resets display if number is pressed directly after 'calculate'

            switch (((Button)sender).Tag) {
                case 1:
                    AddToDisplay("1", rightEq);
                    break;
                case 2:
                    AddToDisplay("2", rightEq);
                    break;
                case 3:
                    AddToDisplay("3", rightEq);
                    break;
                case 4:
                    AddToDisplay("4", rightEq);
                    break;
                case 5:
                    AddToDisplay("5", rightEq);
                    break;
                case 6:
                    AddToDisplay("6", rightEq);
                    break;
                case 7:
                    AddToDisplay("7", rightEq);
                    break;
                case 8:
                    AddToDisplay("8", rightEq);
                    break;
                case 9:
                    AddToDisplay("9", rightEq);
                    break;
                case 0:
                    AddToDisplay("0", rightEq);
                    break;
                case "Dec":
                    AddToDisplay(".", rightEq);
                    break;
                case "PosNeg":
                    //send to posneg method
                    break;
            }
        }//end num btn handler

        private void OpBtnClicked (object sender, EventArgs e)
        {
            string result;

            //resets counter for 'calculate' check

            rightEq = display.Text;
            rightNum = double.Parse(rightEq);

            switch (((Button)sender).Tag)
            {
                case "Add":
                    tempOp = "+";
                    display.Text = "0";
                    break;
                case "Sub":
                    tempOp = "-";
                    display.Text = "0";
                    break;
                case "Calc":
                    leftEq = display.Text;
                    leftNum = double.Parse(leftEq);
                    //when user presses equal prior to an operand
                    if (tempOp == "")
                    {
                        //do nothing
                    }
                    else if (tempOp == "+")
                    {
                        result = Math.Sum(rightNum, leftNum);
                        AddToDisplay(calc, result);
                    } else if (tempOp == "-")
                    {
                        result = Math.Difference(rightNum, leftNum);
                        AddToDisplay(calc, result);
                    }
                    break;
            }
        }//end operand btn handler

        private void MiscBtnclicked (object sender, EventArgs e)
        {
            switch(((Button)sender).Tag)
            {
                case "CE":
                    display.Text = "0";
                    break;
                case "C":
                    rightEq = "0";
                    leftEq = "0";
                    break;
            }

        }//end miscellaneous btn handler



        //----------------------------------METHODS----------------------------------//

        //method to add inputted number/decimal to display
        private void AddToDisplay(string inputDigit, string tempNum)
        {
            if (inputDigit == "=")
            {
                display.Text = tempNum;
            } else if (display.Text.Equals("0"))
            {
                if (!inputDigit.Equals("."))
                {
                    tempNum = inputDigit;
                    display.Text = tempNum;
                } else if (inputDigit.Equals("."))
                {
                    //keeps 0 and adds decimal after
                    tempNum += inputDigit;
                    display.Text = tempNum;
                }
            } else if (inputDigit.Equals("."))
            {
                //prevents adding too many decimals throughout input string
                if (!tempNum.EndsWith(".") && !tempNum.Contains('.'))
                {
                    tempNum += inputDigit;
                    display.Text = tempNum;
                }
            } else
            {
                tempNum += inputDigit;
                display.Text = tempNum;
            }
        }//end display method
    }
}