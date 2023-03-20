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
            if (display.Text == "0")
            {
                switch (((Button)sender).Tag)
                {
                    case 1:
                        display.Text = "1";
                        break;
                    case 2:
                        display.Text = "2"; 
                        break;
                    case 3:
                        display.Text = "3";
                        break;
                    case 4:
                        display.Text = "4";
                        break;
                    case 5:
                        display.Text = "5";
                        break;
                    case 6:
                        display.Text = "6";
                        break;
                    case 7:
                        display.Text = "7";
                        break;
                    case 8:
                        display.Text = "8";
                        break;
                    case 9:
                        display.Text = "9";
                        break;
                }
            } 
            else
            {
                switch (((Button)sender).Tag)
                {
                    case 0:
                        display.Text += "0";
                        break;
                    case 1:
                        display.Text += "1";
                        break;
                    case 2:
                        display.Text += "2";
                        break;
                    case 3:
                        display.Text += "3";
                        break;
                    case 4:
                        display.Text += "4";
                        break;
                    case 5:
                        display.Text += "5";
                        break;
                    case 6:
                        display.Text += "6";
                        break;
                    case 7:
                        display.Text += "7";
                        break;
                    case 8:
                        display.Text += "8";
                        break;
                    case 9:
                        display.Text += "9";
                        break;
                }
            }
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