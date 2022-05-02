using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_with_Exceptions
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!result.Text.Contains("."))
                    result.Text = result.Text + button.Text;
            }
            else
                result.Text = result.Text + button.Text;     
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + "" + operation;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            try
            {
                switch (operation)
                {
                    case "+":
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        break;
                    default:
                        break;
                }//End of switch   
            }
            catch(DivideByZeroException)
            {
                result.Text = "Can't divide by zero!";
                value = 0;
            }
            
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void form_Click(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    subtract.PerformClick();
                    break;
                case "/":
                    divide.PerformClick();
                    break;
                case "*":
                    multi.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }//End of switch
        }
    }
}
