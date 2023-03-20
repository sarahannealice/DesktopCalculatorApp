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
            switch (((Button)sender).Text)
            {
                case "1":
                    display.Text = "1";
                    break;
            }
            /*
            if (sender == btnOne)
            {
                display.Text = "1";
            }*/
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