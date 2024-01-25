namespace Lab02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mButtonsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.mcButton = new System.Windows.Forms.Button();
            this.mrButton = new System.Windows.Forms.Button();
            this.msButton = new System.Windows.Forms.Button();
            this.mplusButton = new System.Windows.Forms.Button();
            this.calcValue = new System.Windows.Forms.TextBox();
            this.calcNumberContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonDeciamlPoint = new System.Windows.Forms.Button();
            this.buttonSignChange = new System.Windows.Forms.Button();
            this.calcOperatorContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.divideButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.remainderButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.oneOverButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.powerOfTwoButton = new System.Windows.Forms.Button();
            this.calcControlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.clearOperandButton = new System.Windows.Forms.Button();
            this.fullClearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.calcOnButton = new System.Windows.Forms.Button();
            this.mButtonsContainer.SuspendLayout();
            this.calcNumberContainer.SuspendLayout();
            this.calcOperatorContainer.SuspendLayout();
            this.calcControlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mButtonsContainer
            // 
            this.mButtonsContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButtonsContainer.BackColor = System.Drawing.SystemColors.Control;
            this.mButtonsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mButtonsContainer.Controls.Add(this.mcButton);
            this.mButtonsContainer.Controls.Add(this.mrButton);
            this.mButtonsContainer.Controls.Add(this.msButton);
            this.mButtonsContainer.Controls.Add(this.mplusButton);
            this.mButtonsContainer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mButtonsContainer.Location = new System.Drawing.Point(140, 69);
            this.mButtonsContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mButtonsContainer.Name = "mButtonsContainer";
            this.mButtonsContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.mButtonsContainer.Size = new System.Drawing.Size(253, 62);
            this.mButtonsContainer.TabIndex = 0;
            this.mButtonsContainer.WrapContents = false;
            // 
            // mcButton
            // 
            this.mcButton.Enabled = false;
            this.mcButton.ForeColor = System.Drawing.Color.Red;
            this.mcButton.Location = new System.Drawing.Point(11, 10);
            this.mcButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcButton.Name = "mcButton";
            this.mcButton.Size = new System.Drawing.Size(52, 38);
            this.mcButton.TabIndex = 0;
            this.mcButton.Text = "MC";
            this.mcButton.UseVisualStyleBackColor = true;
            // 
            // mrButton
            // 
            this.mrButton.Enabled = false;
            this.mrButton.ForeColor = System.Drawing.Color.Red;
            this.mrButton.Location = new System.Drawing.Point(71, 10);
            this.mrButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrButton.Name = "mrButton";
            this.mrButton.Size = new System.Drawing.Size(52, 38);
            this.mrButton.TabIndex = 1;
            this.mrButton.Text = "MR";
            this.mrButton.UseVisualStyleBackColor = true;
            // 
            // msButton
            // 
            this.msButton.Enabled = false;
            this.msButton.ForeColor = System.Drawing.Color.Red;
            this.msButton.Location = new System.Drawing.Point(131, 10);
            this.msButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msButton.Name = "msButton";
            this.msButton.Size = new System.Drawing.Size(52, 38);
            this.msButton.TabIndex = 2;
            this.msButton.Text = "MS";
            this.msButton.UseVisualStyleBackColor = true;
            // 
            // mplusButton
            // 
            this.mplusButton.Enabled = false;
            this.mplusButton.ForeColor = System.Drawing.Color.Red;
            this.mplusButton.Location = new System.Drawing.Point(191, 10);
            this.mplusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mplusButton.Name = "mplusButton";
            this.mplusButton.Size = new System.Drawing.Size(52, 38);
            this.mplusButton.TabIndex = 3;
            this.mplusButton.Text = "M+";
            this.mplusButton.UseVisualStyleBackColor = true;
            // 
            // calcValue
            // 
            this.calcValue.BackColor = System.Drawing.SystemColors.Menu;
            this.calcValue.Location = new System.Drawing.Point(15, 18);
            this.calcValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcValue.Name = "calcValue";
            this.calcValue.Size = new System.Drawing.Size(404, 22);
            this.calcValue.TabIndex = 1;
            this.calcValue.Text = "0";
            this.calcValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calcNumberContainer
            // 
            this.calcNumberContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcNumberContainer.Controls.Add(this.buttonSeven);
            this.calcNumberContainer.Controls.Add(this.buttonEight);
            this.calcNumberContainer.Controls.Add(this.buttonNine);
            this.calcNumberContainer.Controls.Add(this.buttonFour);
            this.calcNumberContainer.Controls.Add(this.buttonFive);
            this.calcNumberContainer.Controls.Add(this.buttonSix);
            this.calcNumberContainer.Controls.Add(this.buttonOne);
            this.calcNumberContainer.Controls.Add(this.buttonTwo);
            this.calcNumberContainer.Controls.Add(this.buttonThree);
            this.calcNumberContainer.Controls.Add(this.buttonZero);
            this.calcNumberContainer.Controls.Add(this.buttonDeciamlPoint);
            this.calcNumberContainer.Controls.Add(this.buttonSignChange);
            this.calcNumberContainer.Location = new System.Drawing.Point(16, 164);
            this.calcNumberContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcNumberContainer.Name = "calcNumberContainer";
            this.calcNumberContainer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calcNumberContainer.Size = new System.Drawing.Size(187, 200);
            this.calcNumberContainer.TabIndex = 2;
            // 
            // buttonSeven
            // 
            this.buttonSeven.Enabled = false;
            this.buttonSeven.ForeColor = System.Drawing.Color.Black;
            this.buttonSeven.Location = new System.Drawing.Point(7, 6);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(52, 41);
            this.buttonSeven.TabIndex = 6;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Enabled = false;
            this.buttonEight.ForeColor = System.Drawing.Color.Black;
            this.buttonEight.Location = new System.Drawing.Point(67, 6);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(52, 41);
            this.buttonEight.TabIndex = 7;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Enabled = false;
            this.buttonNine.ForeColor = System.Drawing.Color.Black;
            this.buttonNine.Location = new System.Drawing.Point(7, 55);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(52, 41);
            this.buttonNine.TabIndex = 8;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Enabled = false;
            this.buttonFour.ForeColor = System.Drawing.Color.Black;
            this.buttonFour.Location = new System.Drawing.Point(67, 55);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(52, 41);
            this.buttonFour.TabIndex = 9;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Enabled = false;
            this.buttonFive.ForeColor = System.Drawing.Color.Black;
            this.buttonFive.Location = new System.Drawing.Point(7, 104);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(52, 41);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Enabled = false;
            this.buttonSix.ForeColor = System.Drawing.Color.Black;
            this.buttonSix.Location = new System.Drawing.Point(67, 104);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(52, 41);
            this.buttonSix.TabIndex = 11;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Enabled = false;
            this.buttonOne.ForeColor = System.Drawing.Color.Black;
            this.buttonOne.Location = new System.Drawing.Point(7, 153);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(52, 41);
            this.buttonOne.TabIndex = 12;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Enabled = false;
            this.buttonTwo.ForeColor = System.Drawing.Color.Black;
            this.buttonTwo.Location = new System.Drawing.Point(67, 153);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(52, 41);
            this.buttonTwo.TabIndex = 13;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Enabled = false;
            this.buttonThree.ForeColor = System.Drawing.Color.Black;
            this.buttonThree.Location = new System.Drawing.Point(7, 202);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(52, 41);
            this.buttonThree.TabIndex = 14;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Enabled = false;
            this.buttonZero.ForeColor = System.Drawing.Color.Black;
            this.buttonZero.Location = new System.Drawing.Point(67, 202);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(52, 41);
            this.buttonZero.TabIndex = 15;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonDeciamlPoint
            // 
            this.buttonDeciamlPoint.Enabled = false;
            this.buttonDeciamlPoint.ForeColor = System.Drawing.Color.Black;
            this.buttonDeciamlPoint.Location = new System.Drawing.Point(7, 251);
            this.buttonDeciamlPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeciamlPoint.Name = "buttonDeciamlPoint";
            this.buttonDeciamlPoint.Size = new System.Drawing.Size(52, 41);
            this.buttonDeciamlPoint.TabIndex = 16;
            this.buttonDeciamlPoint.Text = ".";
            this.buttonDeciamlPoint.UseVisualStyleBackColor = true;
            this.buttonDeciamlPoint.Click += new System.EventHandler(this.buttonDeciamlPoint_Click);
            // 
            // buttonSignChange
            // 
            this.buttonSignChange.Enabled = false;
            this.buttonSignChange.ForeColor = System.Drawing.Color.Black;
            this.buttonSignChange.Location = new System.Drawing.Point(67, 251);
            this.buttonSignChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSignChange.Name = "buttonSignChange";
            this.buttonSignChange.Size = new System.Drawing.Size(52, 41);
            this.buttonSignChange.TabIndex = 17;
            this.buttonSignChange.Text = "+/-";
            this.buttonSignChange.UseVisualStyleBackColor = true;
            // 
            // calcOperatorContainer
            // 
            this.calcOperatorContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcOperatorContainer.Controls.Add(this.divideButton);
            this.calcOperatorContainer.Controls.Add(this.sqrtButton);
            this.calcOperatorContainer.Controls.Add(this.multiplyButton);
            this.calcOperatorContainer.Controls.Add(this.remainderButton);
            this.calcOperatorContainer.Controls.Add(this.subtractButton);
            this.calcOperatorContainer.Controls.Add(this.oneOverButton);
            this.calcOperatorContainer.Controls.Add(this.addButton);
            this.calcOperatorContainer.Controls.Add(this.powerOfTwoButton);
            this.calcOperatorContainer.Location = new System.Drawing.Point(212, 164);
            this.calcOperatorContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcOperatorContainer.Name = "calcOperatorContainer";
            this.calcOperatorContainer.Padding = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.calcOperatorContainer.Size = new System.Drawing.Size(130, 200);
            this.calcOperatorContainer.TabIndex = 3;
            // 
            // divideButton
            // 
            this.divideButton.Enabled = false;
            this.divideButton.ForeColor = System.Drawing.Color.Black;
            this.divideButton.Location = new System.Drawing.Point(8, 6);
            this.divideButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(52, 41);
            this.divideButton.TabIndex = 7;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Enabled = false;
            this.sqrtButton.ForeColor = System.Drawing.Color.Black;
            this.sqrtButton.Location = new System.Drawing.Point(68, 6);
            this.sqrtButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(52, 41);
            this.sqrtButton.TabIndex = 8;
            this.sqrtButton.Text = "sqrt";
            this.sqrtButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Enabled = false;
            this.multiplyButton.ForeColor = System.Drawing.Color.Black;
            this.multiplyButton.Location = new System.Drawing.Point(8, 55);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(52, 41);
            this.multiplyButton.TabIndex = 9;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // remainderButton
            // 
            this.remainderButton.Enabled = false;
            this.remainderButton.ForeColor = System.Drawing.Color.Black;
            this.remainderButton.Location = new System.Drawing.Point(68, 55);
            this.remainderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remainderButton.Name = "remainderButton";
            this.remainderButton.Size = new System.Drawing.Size(52, 41);
            this.remainderButton.TabIndex = 10;
            this.remainderButton.Text = "%";
            this.remainderButton.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            this.subtractButton.Enabled = false;
            this.subtractButton.ForeColor = System.Drawing.Color.Black;
            this.subtractButton.Location = new System.Drawing.Point(8, 104);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(52, 41);
            this.subtractButton.TabIndex = 11;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // oneOverButton
            // 
            this.oneOverButton.Enabled = false;
            this.oneOverButton.ForeColor = System.Drawing.Color.Black;
            this.oneOverButton.Location = new System.Drawing.Point(68, 104);
            this.oneOverButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oneOverButton.Name = "oneOverButton";
            this.oneOverButton.Size = new System.Drawing.Size(52, 41);
            this.oneOverButton.TabIndex = 12;
            this.oneOverButton.Text = "1/x";
            this.oneOverButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(8, 153);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(52, 41);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // powerOfTwoButton
            // 
            this.powerOfTwoButton.Enabled = false;
            this.powerOfTwoButton.ForeColor = System.Drawing.Color.Black;
            this.powerOfTwoButton.Location = new System.Drawing.Point(68, 153);
            this.powerOfTwoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powerOfTwoButton.Name = "powerOfTwoButton";
            this.powerOfTwoButton.Size = new System.Drawing.Size(52, 41);
            this.powerOfTwoButton.TabIndex = 14;
            this.powerOfTwoButton.Text = "x^2";
            this.powerOfTwoButton.UseVisualStyleBackColor = true;
            // 
            // calcControlContainer
            // 
            this.calcControlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcControlContainer.Controls.Add(this.clearOperandButton);
            this.calcControlContainer.Controls.Add(this.fullClearButton);
            this.calcControlContainer.Controls.Add(this.backButton);
            this.calcControlContainer.Controls.Add(this.equalButton);
            this.calcControlContainer.Location = new System.Drawing.Point(351, 164);
            this.calcControlContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcControlContainer.Name = "calcControlContainer";
            this.calcControlContainer.Padding = new System.Windows.Forms.Padding(1, 6, 1, 1);
            this.calcControlContainer.Size = new System.Drawing.Size(65, 200);
            this.calcControlContainer.TabIndex = 4;
            // 
            // clearOperandButton
            // 
            this.clearOperandButton.Enabled = false;
            this.clearOperandButton.ForeColor = System.Drawing.Color.Red;
            this.clearOperandButton.Location = new System.Drawing.Point(5, 10);
            this.clearOperandButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearOperandButton.Name = "clearOperandButton";
            this.clearOperandButton.Size = new System.Drawing.Size(52, 38);
            this.clearOperandButton.TabIndex = 1;
            this.clearOperandButton.Text = "CE";
            this.clearOperandButton.UseVisualStyleBackColor = true;
            // 
            // fullClearButton
            // 
            this.fullClearButton.Enabled = false;
            this.fullClearButton.ForeColor = System.Drawing.Color.Red;
            this.fullClearButton.Location = new System.Drawing.Point(5, 56);
            this.fullClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullClearButton.Name = "fullClearButton";
            this.fullClearButton.Size = new System.Drawing.Size(52, 38);
            this.fullClearButton.TabIndex = 2;
            this.fullClearButton.Text = "C";
            this.fullClearButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(5, 102);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(52, 38);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "<--";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // equalButton
            // 
            this.equalButton.Enabled = false;
            this.equalButton.ForeColor = System.Drawing.Color.Black;
            this.equalButton.Location = new System.Drawing.Point(5, 148);
            this.equalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(52, 41);
            this.equalButton.TabIndex = 6;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            // 
            // calcOnButton
            // 
            this.calcOnButton.ForeColor = System.Drawing.Color.Black;
            this.calcOnButton.Location = new System.Drawing.Point(52, 79);
            this.calcOnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calcOnButton.Name = "calcOnButton";
            this.calcOnButton.Size = new System.Drawing.Size(52, 41);
            this.calcOnButton.TabIndex = 5;
            this.calcOnButton.Text = "On";
            this.calcOnButton.UseVisualStyleBackColor = true;
            this.calcOnButton.Click += new System.EventHandler(this.calcOnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 558);
            this.Controls.Add(this.calcOnButton);
            this.Controls.Add(this.calcControlContainer);
            this.Controls.Add(this.calcOperatorContainer);
            this.Controls.Add(this.calcNumberContainer);
            this.Controls.Add(this.calcValue);
            this.Controls.Add(this.mButtonsContainer);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Calculator";
            this.mButtonsContainer.ResumeLayout(false);
            this.calcNumberContainer.ResumeLayout(false);
            this.calcOperatorContainer.ResumeLayout(false);
            this.calcControlContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mButtonsContainer;
        private System.Windows.Forms.TextBox calcValue;
        private System.Windows.Forms.FlowLayoutPanel calcNumberContainer;
        private System.Windows.Forms.FlowLayoutPanel calcOperatorContainer;
        private System.Windows.Forms.FlowLayoutPanel calcControlContainer;
        private System.Windows.Forms.Button calcOnButton;
        private System.Windows.Forms.Button mcButton;
        private System.Windows.Forms.Button mrButton;
        private System.Windows.Forms.Button msButton;
        private System.Windows.Forms.Button mplusButton;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonDeciamlPoint;
        private System.Windows.Forms.Button buttonSignChange;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button remainderButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button oneOverButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button powerOfTwoButton;
        private System.Windows.Forms.Button clearOperandButton;
        private System.Windows.Forms.Button fullClearButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button equalButton;
    }
}

