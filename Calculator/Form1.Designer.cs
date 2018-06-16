namespace Calculator
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonNegation = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.labelPreview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxResult.ForeColor = System.Drawing.Color.Black;
            this.textBoxResult.Location = new System.Drawing.Point(5, 39);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxResult.Size = new System.Drawing.Size(276, 29);
            this.textBoxResult.TabIndex = 39;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Ivory;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPlus.Location = new System.Drawing.Point(236, 231);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 43);
            this.buttonPlus.TabIndex = 38;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonC.FlatAppearance.BorderSize = 23;
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonC.ForeColor = System.Drawing.Color.Black;
            this.buttonC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonC.Location = new System.Drawing.Point(185, 74);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(96, 43);
            this.buttonC.TabIndex = 37;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.clearAllButtonClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonEqual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEqual.Location = new System.Drawing.Point(185, 178);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(45, 96);
            this.buttonEqual.TabIndex = 36;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Ivory;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMultiply.Location = new System.Drawing.Point(236, 123);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(45, 43);
            this.buttonMultiply.TabIndex = 35;
            this.buttonMultiply.Text = "x";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Ivory;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDivide.Location = new System.Drawing.Point(185, 123);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(45, 43);
            this.buttonDivide.TabIndex = 34;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Ivory;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMinus.Location = new System.Drawing.Point(236, 178);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 43);
            this.buttonMinus.TabIndex = 33;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.operationButtonClick);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Ivory;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button0.Location = new System.Drawing.Point(64, 231);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(45, 43);
            this.button0.TabIndex = 32;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.Ivory;
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonPoint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPoint.Location = new System.Drawing.Point(125, 231);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(45, 43);
            this.buttonPoint.TabIndex = 31;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(5, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Ivory;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(64, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 43);
            this.button5.TabIndex = 29;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Ivory;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(125, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 43);
            this.button6.TabIndex = 28;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // buttonNegation
            // 
            this.buttonNegation.BackColor = System.Drawing.Color.Ivory;
            this.buttonNegation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonNegation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNegation.Location = new System.Drawing.Point(5, 231);
            this.buttonNegation.Name = "buttonNegation";
            this.buttonNegation.Size = new System.Drawing.Size(45, 43);
            this.buttonNegation.TabIndex = 27;
            this.buttonNegation.Text = "±";
            this.buttonNegation.UseVisualStyleBackColor = false;
            this.buttonNegation.Click += new System.EventHandler(this.negationButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(64, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 26;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(125, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 25;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Ivory;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button9.Location = new System.Drawing.Point(125, 74);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 43);
            this.button9.TabIndex = 24;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Ivory;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(5, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 43);
            this.button4.TabIndex = 23;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Ivory;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button8.Location = new System.Drawing.Point(64, 74);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 43);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Ivory;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(5, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 43);
            this.button7.TabIndex = 21;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numberButtonClick);
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelPreview.ForeColor = System.Drawing.Color.DimGray;
            this.labelPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPreview.Location = new System.Drawing.Point(12, 9);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(0, 22);
            this.labelPreview.TabIndex = 40;
            this.labelPreview.Click += new System.EventHandler(this.labelPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 290);
            this.Controls.Add(this.labelPreview);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonNegation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonNegation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label labelPreview;
    }
}

