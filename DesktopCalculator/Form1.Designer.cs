namespace DesktopCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCE = new Button();
            btnC = new Button();
            btnDelete = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSubtract = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnAdd = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnCalc = new Button();
            btnDecimal = new Button();
            btnZero = new Button();
            btnPosNeg = new Button();
            display = new Label();
            SuspendLayout();
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.PaleVioletRed;
            btnCE.ForeColor = Color.LavenderBlush;
            btnCE.Location = new Point(12, 96);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(74, 37);
            btnCE.TabIndex = 1;
            btnCE.Tag = "CE";
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += MiscBtnclicked;
            // 
            // btnC
            // 
            btnC.BackColor = Color.PaleVioletRed;
            btnC.ForeColor = Color.LavenderBlush;
            btnC.Location = new Point(92, 96);
            btnC.Name = "btnC";
            btnC.Size = new Size(74, 37);
            btnC.TabIndex = 2;
            btnC.Tag = "C";
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += MiscBtnclicked;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleVioletRed;
            btnDelete.ForeColor = Color.LavenderBlush;
            btnDelete.Location = new Point(172, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Tag = "Del";
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += MiscBtnclicked;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.PaleVioletRed;
            btnDivide.ForeColor = Color.LavenderBlush;
            btnDivide.Location = new Point(253, 96);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(74, 37);
            btnDivide.TabIndex = 4;
            btnDivide.Tag = "Div";
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += OpBtnClicked;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.PaleVioletRed;
            btnMultiply.ForeColor = Color.LavenderBlush;
            btnMultiply.Location = new Point(253, 139);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(74, 37);
            btnMultiply.TabIndex = 8;
            btnMultiply.Tag = "Mult";
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += OpBtnClicked;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.Pink;
            btnNine.ForeColor = SystemColors.WindowText;
            btnNine.Location = new Point(172, 139);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(74, 37);
            btnNine.TabIndex = 7;
            btnNine.Tag = 9;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += NumBtnClicked;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.Pink;
            btnEight.ForeColor = SystemColors.WindowText;
            btnEight.Location = new Point(92, 139);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(74, 37);
            btnEight.TabIndex = 6;
            btnEight.Tag = 8;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += NumBtnClicked;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.Pink;
            btnSeven.ForeColor = SystemColors.WindowText;
            btnSeven.Location = new Point(12, 139);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(74, 37);
            btnSeven.TabIndex = 5;
            btnSeven.Tag = 7;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += NumBtnClicked;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.PaleVioletRed;
            btnSubtract.ForeColor = Color.LavenderBlush;
            btnSubtract.Location = new Point(253, 181);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(74, 37);
            btnSubtract.TabIndex = 12;
            btnSubtract.Tag = "Sub";
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += OpBtnClicked;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.Pink;
            btnSix.ForeColor = SystemColors.WindowText;
            btnSix.Location = new Point(172, 181);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(74, 37);
            btnSix.TabIndex = 11;
            btnSix.Tag = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += NumBtnClicked;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.Pink;
            btnFive.ForeColor = SystemColors.WindowText;
            btnFive.Location = new Point(92, 181);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(74, 37);
            btnFive.TabIndex = 10;
            btnFive.Tag = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += NumBtnClicked;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.Pink;
            btnFour.ForeColor = SystemColors.WindowText;
            btnFour.Location = new Point(12, 181);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(74, 37);
            btnFour.TabIndex = 9;
            btnFour.Tag = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += NumBtnClicked;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleVioletRed;
            btnAdd.ForeColor = Color.LavenderBlush;
            btnAdd.Location = new Point(253, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 37);
            btnAdd.TabIndex = 16;
            btnAdd.Tag = "Add";
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += OpBtnClicked;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.Pink;
            btnThree.ForeColor = SystemColors.WindowText;
            btnThree.Location = new Point(172, 223);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(74, 37);
            btnThree.TabIndex = 15;
            btnThree.Tag = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += NumBtnClicked;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.Pink;
            btnTwo.ForeColor = SystemColors.WindowText;
            btnTwo.Location = new Point(92, 223);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(74, 37);
            btnTwo.TabIndex = 14;
            btnTwo.Tag = 2;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += NumBtnClicked;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.Pink;
            btnOne.ForeColor = SystemColors.WindowText;
            btnOne.Location = new Point(12, 223);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(74, 37);
            btnOne.TabIndex = 13;
            btnOne.Tag = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += NumBtnClicked;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.PaleVioletRed;
            btnCalc.ForeColor = Color.LavenderBlush;
            btnCalc.Location = new Point(253, 266);
            btnCalc.Name = "btnCalc";
            btnCalc.RightToLeft = RightToLeft.No;
            btnCalc.Size = new Size(74, 37);
            btnCalc.TabIndex = 20;
            btnCalc.Tag = "Calc";
            btnCalc.Text = "=";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += OpBtnClicked;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.PaleVioletRed;
            btnDecimal.ForeColor = Color.LavenderBlush;
            btnDecimal.Location = new Point(172, 266);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(74, 37);
            btnDecimal.TabIndex = 19;
            btnDecimal.Tag = "Dec";
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += NumBtnClicked;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.Pink;
            btnZero.ForeColor = SystemColors.WindowText;
            btnZero.Location = new Point(92, 266);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(74, 37);
            btnZero.TabIndex = 18;
            btnZero.Tag = 0;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += NumBtnClicked;
            // 
            // btnPosNeg
            // 
            btnPosNeg.BackColor = Color.PaleVioletRed;
            btnPosNeg.ForeColor = Color.LavenderBlush;
            btnPosNeg.Location = new Point(12, 266);
            btnPosNeg.Name = "btnPosNeg";
            btnPosNeg.Size = new Size(74, 37);
            btnPosNeg.TabIndex = 17;
            btnPosNeg.Tag = "PosNeg";
            btnPosNeg.Text = "+/-";
            btnPosNeg.UseVisualStyleBackColor = false;
            // 
            // display
            // 
            display.BackColor = Color.LavenderBlush;
            display.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            display.Location = new Point(12, 31);
            display.Name = "display";
            display.Size = new Size(315, 43);
            display.TabIndex = 23;
            display.Text = "0";
            display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(339, 328);
            Controls.Add(display);
            Controls.Add(btnCalc);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(btnPosNeg);
            Controls.Add(btnAdd);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnSubtract);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnMultiply);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnDivide);
            Controls.Add(btnDelete);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Cursor = Cursors.WaitCursor;
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCE;
        private Button btnC;
        private Button btnDelete;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSubtract;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnAdd;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnCalc;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnPosNeg;
        private Label display;
    }
}