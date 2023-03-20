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
            tempNum = display.Text;

            switch (((Button)sender).Tag)
            {
                case 1:
                    AddToDisplay("1", tempNum);
                    break;
                case 2:
                    AddToDisplay("2", tempNum);
                    break;
                case 3:
                    AddToDisplay("3", tempNum);
                    break;
                case 4:
                    AddToDisplay("4", tempNum);
                    break;
                case 5:
                    AddToDisplay("5", tempNum);
                    break;
                case 6:
                    AddToDisplay("6", tempNum);
                    break;
                case 7:
                    AddToDisplay("7", tempNum);
                    break;
                case 8:
                    AddToDisplay("8", tempNum);
                    break;
                case 9:
                    AddToDisplay("9", tempNum);
                    break;
                case 0:
                    AddToDisplay("0", tempNum);
                    break;
                case "Dec":
                    AddToDisplay(".", tempNum);
                    break;
                case "PosNeg":
                    //send to posneg method
                    break;
            }
        }//end num btn handler

        private void OpBtnClicked(object sender, EventArgs e)
        {
            string result;

            switch (((Button)sender).Tag)
            {
                case "Add":
                    rightEq = display.Text;
                    tempOp = "+";
                    display.Text = "0";
                    break;
                case "Sub":
                    rightEq = display.Text;
                    tempOp = "-";
                    display.Text = "0";
                    break;
                case "Mult":
                    rightEq = display.Text;
                    tempOp = "*";
                    display.Text = "0";
                    break;
                case "Div":
                    rightEq = display.Text;
                    tempOp = "/";
                    display.Text = "0";
                    break;
                case "Calc":
                    leftEq = display.Text;
                    leftNum = double.Parse(leftEq);
                    rightNum = double.Parse(rightEq);

                    if (tempOp == "+")
                    {
                        result = Math.Sum(rightNum, leftNum);
                        display.Text = result;
                    }
                    else if (tempOp == "-")
                    {
                        result = Math.Difference(rightNum, leftNum);
                        display.Text = result;
                    }
                    else if (tempOp == "*")
                    {
                        result = Math.Product(rightNum, leftNum);
                        display.Text = result;
                    }
                    else if (tempOp == "/")
                    {
                        result = Math.Quotient(rightNum, leftNum);
                        display.Text = result;
                    }
                    break;
            }
        }//end operand btn handler

        private void MiscBtnclicked(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "CE":
                    display.Text = "0";
                    break;
                case "C":
                    rightEq = "0";
                    leftEq = "0";
                    display.Text = "0";
                    break;
                case "Del":
                    tempNum = display.Text;
                    DeleteDigit(tempNum);
                    break;
            }

        }//end miscellaneous btn handler



        //----------------------------------METHODS----------------------------------//
        //method to delete digit
        private void DeleteDigit(string tempNum)
        {
            if (tempNum == "0")
            {
                //do nothing -- keeps screen at 0
            }
            else if (tempNum.Length == 1)
            {
                //changes screen to 0 when at last digit
                display.Text = "0";
            }
            else
            {
                tempNum = tempNum.Remove(tempNum.Length - 1, 1);
                display.Text = tempNum;
            }
        }//end delete digit method

        //method to add inputted number/decimal to display
        private void AddToDisplay(string inputDigit, string tempNum)
        {
            if (tempNum.Equals("0"))
            {
                if (inputDigit.Equals("."))
                {
                    //keeps 0 and adds decimal after
                    display.Text += inputDigit;
                }
                else
                {
                    display.Text = inputDigit;
                }
            }
            else if (inputDigit.Equals(".") && tempNum.Contains('.'))
            {
                //do nothing
            }
            else
            {
                display.Text += inputDigit;
            }
        }//end display method
    }
}