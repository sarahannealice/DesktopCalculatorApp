namespace DesktopCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumBtnClickHandler(object sender, EventArgs e)
        {
            if (display.Equals("0"))
            {
                switch (sender)
                {
                    case "btnZero":
                        display.Text = "0";
                        break;
                    case "btnOne":
                        display.Text = "1";
                        break;
                    case "btnTwo":
                        display.Text = "2";
                        break;
                    case "btnThree":
                        display.Text = "3";
                        break;
                    case "btnFour":
                        display.Text = "4";
                        break;
                    case "btnFive":
                        display.Text = "5";
                        break;
                    case "btnSix":
                        display.Text = "6";
                        break;
                    case "btnSeven":
                        display.Text = "7";
                        break;
                    case "btnEight":
                        display.Text = "8";
                        break;
                    case "btnNine":
                        display.Text = "9";
                        break;
                }
            } 
            else
            {
                switch (sender)
                {
                    case "btnZero":
                        display.Text += "0";
                        break;
                    case "btnOne":
                        display.Text += "1";
                        break;
                    case "btnTwo":
                        display.Text += "2";
                        break;
                    case "btnThree":
                        display.Text += "3";
                        break;
                    case "btnFour":
                        display.Text += "4";
                        break;
                    case "btnFive":
                        display.Text += "5";
                        break;
                    case "btnSix":
                        display.Text += "6";
                        break;
                    case "btnSeven":
                        display.Text += "7";
                        break;
                    case "btnEight":
                        display.Text += "8";
                        break;
                    case "btnNine":
                        display.Text += "9";
                        break;
                }
            }
        }

        //label1 might be for the form itself, not sure
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click_1(object sender, EventArgs e)
        {
            btnZero.Click += NumBtnClickHandler;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }
    }
}