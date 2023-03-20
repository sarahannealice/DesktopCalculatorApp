﻿namespace DesktopCalculator
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
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPosNeg = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCE.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCE.Location = new System.Drawing.Point(12, 96);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(74, 37);
            this.btnCE.TabIndex = 1;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnC.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnC.Location = new System.Drawing.Point(92, 96);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(74, 37);
            this.btnC.TabIndex = 2;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.Location = new System.Drawing.Point(172, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "Del";
            this.btnDelete.Text = "⌫";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDivide.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDivide.Location = new System.Drawing.Point(253, 96);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(74, 37);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Tag = "Div";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMultiply.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnMultiply.Location = new System.Drawing.Point(253, 139);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(74, 37);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Tag = "Mult";
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Pink;
            this.btnNine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnNine.Location = new System.Drawing.Point(172, 139);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(74, 37);
            this.btnNine.TabIndex = 7;
            this.btnNine.Tag = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Pink;
            this.btnEight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEight.Location = new System.Drawing.Point(92, 139);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(74, 37);
            this.btnEight.TabIndex = 6;
            this.btnEight.Tag= 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Pink;
            this.btnSeven.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSeven.Location = new System.Drawing.Point(12, 139);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(74, 37);
            this.btnSeven.TabIndex = 5;
            this.btnSeven.Tag= 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubtract.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSubtract.Location = new System.Drawing.Point(253, 181);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(74, 37);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Tag = "Sub";
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Pink;
            this.btnSix.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSix.Location = new System.Drawing.Point(172, 181);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(74, 37);
            this.btnSix.TabIndex = 11;
            this.btnSix.Tag = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Pink;
            this.btnFive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFive.Location = new System.Drawing.Point(92, 181);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(74, 37);
            this.btnFive.TabIndex = 10;
            this.btnFive.Tag = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Pink;
            this.btnFour.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFour.Location = new System.Drawing.Point(12, 181);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(74, 37);
            this.btnFour.TabIndex = 9;
            this.btnFour.Tag = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnAdd.Location = new System.Drawing.Point(253, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 37);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Pink;
            this.btnThree.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnThree.Location = new System.Drawing.Point(172, 223);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(74, 37);
            this.btnThree.TabIndex = 15;
            this.btnThree.Tag = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Pink;
            this.btnTwo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnTwo.Location = new System.Drawing.Point(92, 223);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(74, 37);
            this.btnTwo.TabIndex = 14;
            this.btnTwo.Tag = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Pink;
            this.btnOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnOne.Location = new System.Drawing.Point(12, 223);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(74, 37);
            this.btnOne.TabIndex = 13;
            this.btnOne.Tag = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSum.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSum.Location = new System.Drawing.Point(253, 266);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(74, 37);
            this.btnSum.TabIndex = 20;
            this.btnSum.Tag = "Sum";
            this.btnSum.Text = "=";
            this.btnSum.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDecimal.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDecimal.Location = new System.Drawing.Point(172, 266);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(74, 37);
            this.btnDecimal.TabIndex = 19;
            this.btnDecimal.Tag = "Dec";
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Pink;
            this.btnZero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnZero.Location = new System.Drawing.Point(92, 266);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(74, 37);
            this.btnZero.TabIndex = 18;
            this.btnZero.Tag = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(NumBtnClicked);
            // 
            // btnPosNeg
            // 
            this.btnPosNeg.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPosNeg.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnPosNeg.Location = new System.Drawing.Point(12, 266);
            this.btnPosNeg.Name = "btnPosNeg";
            this.btnPosNeg.Size = new System.Drawing.Size(74, 37);
            this.btnPosNeg.TabIndex = 17;
            this.btnPosNeg.Tag = "PosNeg";
            this.btnPosNeg.Text = "+/-";
            this.btnPosNeg.UseVisualStyleBackColor = false;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.LavenderBlush;
            this.display.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(12, 31);
            this.display.Name = "display";
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(315, 38);
            this.display.TabIndex = 21;
            this.display.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(339, 328);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPosNeg);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form1";
            this.ResumeLayout(false);

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
        private Button btnSum;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnPosNeg;
        private Label display;
    }
}