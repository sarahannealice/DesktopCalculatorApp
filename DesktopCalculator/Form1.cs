namespace DesktopCalculator
{
    public partial class Form1 : Form
    {
     
        //variables
        private string rightEq;
        private string leftEq;
        private double rightNum;
        private double leftNum;



        public Form1()
        {
            InitializeComponent();
        }

        //----------------------------------EVENT HANDLERS----------------------------------//
        private void NumBtnClicked(object sender, EventArgs e)
        {
            //resets display if number is pressed directly after 'calculate'
            rightEq = display.Text;

            switch (((Button)sender).Tag) {
                case 0:
                    AddToDisplay("0", rightEq);
                    break;
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
                case "Dec":
                    AddToDisplay(".", rightEq);
                    break;
                case "PosNeg":
                    //send to posneg method
                    break;
            }
        }

        private void OpBtnClicked (object sender, EventArgs e)
        {
            rightNum = double.Parse(rightEq);
            leftEq = display.Text;
            leftNum = double.Parse(leftEq);

            //resets counter for 'calculate' check

            switch (((Button)sender).Tag)
            {
                case "Add":
                    Math.Sum(rightNum, leftNum);
                    break;
            }
        }

        private void MiscBtnclicked (object sender, EventArgs e)
        {
            switch(((Button)sender).Tag)
            {
                case "CE":
                    display.Text = "0";
                    break;
            }

        }



        //----------------------------------METHODS----------------------------------//
        //method to add inputted number/decimal to display
        private void AddToDisplay(string inputDigit, string rightEq)
        {
            if (display.Text.Equals('0'))
            {
                if (!inputDigit.Equals('.'))
                {
                    display.Text = inputDigit;
                } else if (inputDigit.Equals('.'))
                {
                    //keeps 0 and adds decimal after
                    rightEq += inputDigit;
                    display.Text = rightEq;
                } else
                {
                    display.Text += inputDigit;
                }
            } else if (inputDigit.Equals('.'))
            {
                //prevents adding too many decimals throughout input string
                if (!rightEq.EndsWith('.') && !rightEq.Contains('.'))
                {
                    rightEq += inputDigit;
                    display.Text = rightEq;
                }
            } else
            {
                rightEq += inputDigit;
                display.Text = rightEq;
            }
        }//end display method
    }
}