namespace Calculator
{
    partial class CalcForm
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
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.PluminusButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.ClearEraseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.Color.Khaki;
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.Location = new System.Drawing.Point(25, 12);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(366, 44);
            this.DisplayTextBox.TabIndex = 0;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PluminusButton
            // 
            this.PluminusButton.Location = new System.Drawing.Point(23, 282);
            this.PluminusButton.Name = "PluminusButton";
            this.PluminusButton.Size = new System.Drawing.Size(59, 58);
            this.PluminusButton.TabIndex = 1;
            this.PluminusButton.Text = "+/-";
            this.PluminusButton.UseVisualStyleBackColor = true;
            this.PluminusButton.Click += new System.EventHandler(this.PluminusButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(88, 282);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(59, 58);
            this.ZeroButton.TabIndex = 1;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // DotButton
            // 
            this.DotButton.Location = new System.Drawing.Point(153, 282);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(59, 58);
            this.DotButton.TabIndex = 1;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(269, 282);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(59, 58);
            this.EqualButton.TabIndex = 1;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PercentageButton
            // 
            this.PercentageButton.Location = new System.Drawing.Point(334, 282);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(59, 58);
            this.PercentageButton.TabIndex = 1;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = true;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(23, 218);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(59, 58);
            this.OneButton.TabIndex = 1;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(88, 218);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(59, 58);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(153, 218);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(59, 58);
            this.ThreeButton.TabIndex = 1;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(269, 218);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(59, 58);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(334, 218);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(59, 58);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(23, 154);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(59, 58);
            this.FourButton.TabIndex = 1;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(88, 154);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(59, 58);
            this.FiveButton.TabIndex = 1;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(153, 154);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(59, 58);
            this.SixButton.TabIndex = 1;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(269, 154);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(59, 58);
            this.DivideButton.TabIndex = 1;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(334, 154);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(59, 58);
            this.MultiplyButton.TabIndex = 1;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(23, 90);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(59, 58);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(88, 90);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(59, 58);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(153, 90);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(59, 58);
            this.NineButton.TabIndex = 1;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.DigitBtn_Click);
            // 
            // ClearEraseButton
            // 
            this.ClearEraseButton.Location = new System.Drawing.Point(269, 90);
            this.ClearEraseButton.Name = "ClearEraseButton";
            this.ClearEraseButton.Size = new System.Drawing.Size(59, 58);
            this.ClearEraseButton.TabIndex = 1;
            this.ClearEraseButton.Text = "CE";
            this.ClearEraseButton.UseVisualStyleBackColor = true;
            this.ClearEraseButton.Click += new System.EventHandler(this.ClearEraseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(334, 90);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(59, 58);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 379);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PercentageButton);
            this.Controls.Add(this.ClearEraseButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.PluminusButton);
            this.Controls.Add(this.DisplayTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button PluminusButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button PercentageButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button ClearEraseButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

