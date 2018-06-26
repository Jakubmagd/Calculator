using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form

    {
        private Double result = 0;
        private String operation = "";
        private bool isOperationPerformed = false; ///do czyszczenia textboxu i wpisanie nowej wartości
        bool isNumberPerformed = false;            ///aby uniknac konfliktow
        bool isDivideByZeroPerformed = false;      ///zatrzymanie dzialania po dzieleniu przez zero


        /// sektory
        public double Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public string Operation
        {
            get
            {
                return operation;
            }

            set
            {
                operation = value;
            }
        }

        public bool IsOperationPerformed
        {
            get
            {
                return isOperationPerformed;
            }

            set
            {
                isOperationPerformed = value;
            }
        }

        public bool IsNumberPerformed
        {
            get
            {
                return isNumberPerformed;
            }

            set
            {
                isNumberPerformed = value;
            }
        }

        public bool IsDivideByZeroPerformed
        {
            get
            {
                return isDivideByZeroPerformed;
            }

            set
            {
                isDivideByZeroPerformed = value;
            }
        }
        //


        public Form1()
        {

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US"); 
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            InitializeComponent();
        }

        private void numberButtonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            IsNumberPerformed = true;

            if (IsOperationPerformed)
            {

                textBoxResult.Clear();

            }
            IsOperationPerformed = false;

            if (textBoxResult.Text.Length <= 15)
            {
                if (button.Text == ".") 
                {

                    if (!(textBoxResult.Text.Contains(".")))
                    {
                        if (textBoxResult.Text == "")  /// dodaj zero przed przecinkiem
                        {
                            textBoxResult.Text = "0" + button.Text;
                        }
                        else
                        {
                            textBoxResult.Text = textBoxResult.Text + button.Text;
                        }

                    }
                }
                else if (button.Text == "0")   ///aby uniknac za duzo zer przed przecinkiem
                {
                    if (textBoxResult.Text != "0")
                    {
                        textBoxResult.Text = textBoxResult.Text + button.Text;
                    }
                }
                else
                {
                    if (textBoxResult.Text == "0") ///aby uniknac zer przed liczba
                    {
                        textBoxResult.Text = button.Text;
                    }
                    else
                    {
                        textBoxResult.Text = textBoxResult.Text + button.Text;
                    }
                }
            }


        }

        private void operationButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (IsNumberPerformed)
            {

                switch (Operation)
                {
                    case "+":

                        textBoxResult.Text = (Result + Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "-":

                        textBoxResult.Text = (Result - Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "x":
                        textBoxResult.Text = (Result * Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "/":
                        if (Double.Parse(textBoxResult.Text) == 0)
                        {
                            MessageBox.Show("NIE MOZNA DZIELIC PRZEZ ZERO"); ///informacja dzielenia przez 0
                            buttonC.PerformClick();
                            IsDivideByZeroPerformed = true;
                            break;
                        }
                        else
                        {
                            textBoxResult.Text = (Result / Double.Parse(textBoxResult.Text)).ToString();
                            break;
                        }
                    default:
                        break;

                }

                IsNumberPerformed = false;

            }

            if (!IsDivideByZeroPerformed)
            {
                if (button.Text == "=")
                {
                    Operation = "";

                    try
                    {
                        Result = Double.Parse(textBoxResult.Text);
                    }
                    catch (FormatException)
                    {

                        Result = 0;
                        textBoxResult.Text = Result.ToString();

                    }

                    IsNumberPerformed = true;
                    labelPreview.Text = "";
                    IsOperationPerformed = false;

                }

                else
                {
                    Operation = button.Text;       /// operator jest wybrany

                    try
                    {
                        Result = Double.Parse(textBoxResult.Text);
                    }
                    catch (FormatException)
                    {

                        Result = 0;
                        textBoxResult.Text = Result.ToString();

                    }

                    labelPreview.Text = textBoxResult.Text + " " + Operation;
                    IsOperationPerformed = true;
                }


            }


            IsDivideByZeroPerformed = false;

        }


        private void clearAllButtonClick(object sender, EventArgs e)
        {

            textBoxResult.Text = "";
            Result = 0;
            Operation = "";
            IsNumberPerformed = false;
            IsOperationPerformed = false;
            labelPreview.Text = "";

        }

        private void negationButtonClick(object sender, EventArgs e)
        {

            try
            {
                textBoxResult.Text = (-1 * Double.Parse(textBoxResult.Text)).ToString();
                IsNumberPerformed = true;
            }
            catch (FormatException)
            {
                Result = 0;
                textBoxResult.Text = Result.ToString();
            }

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPreview_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
