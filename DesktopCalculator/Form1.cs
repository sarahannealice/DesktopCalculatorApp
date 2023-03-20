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
                    addToDisplay("0", rightEq);
                    break;
                case 1:
                    addToDisplay("1", rightEq);
                    break;
                case 2:
                    addToDisplay("2", rightEq);
                    break;
                case 3:
                    addToDisplay("3", rightEq);
                    break;
                case 4:
                    addToDisplay("4", rightEq);
                    break;
                case 5:
                    addToDisplay("5", rightEq);
                    break;
                case 6:
                    addToDisplay("6", rightEq);
                    break;
                case 7:
                    addToDisplay("7", rightEq);
                    break;
                case 8:
                    addToDisplay("8", rightEq);
                    break;
                case 9:
                    addToDisplay("9", rightEq);
                    break;
                case "Dec":
                    addToDisplay(".", rightEq);
                    break;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }









        //----------------------------------METHODS----------------------------------//
        private void addToDisplay(string inputDigit, string rightEq)
        {
            if (display.Text.Equals("0"))
            {
                if (!inputDigit.Equals("."))
                {
                    display.Text = inputDigit;
                } else if (inputDigit.Equals("."))
                {
                    //keeps 0 and adds decimal after
                    rightEq += inputDigit;
                    display.Text += rightEq;
                } else
                {
                    display.Text += inputDigit;
                }
            } else if (inputDigit.Equals("."))
            {
                //prevents adding too many decimals throughout input string
                if (!rightEq.EndsWith(".") && !rightEq.Contains("."))
                {
                    rightEq += inputDigit;
                    display.Text += rightEq;
                }
            } else
            {
                rightEq += inputDigit;
                display.Text += inputDigit;
            }
        }

    }
}