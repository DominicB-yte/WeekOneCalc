using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeekOneCalc
{
    public partial class MainPage : ContentPage
    {
        string equation;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string newNum;
            String name = button.Text;
            switch(name)
            {
                case "1":
                    newNum = string.Concat(Number.Text, "1");
                    Number.Text = newNum;
                    Console.WriteLine("One");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "2":
                    newNum = string.Concat(Number.Text, "2");
                    Number.Text = newNum;
                    Console.WriteLine("Two");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "3":
                    newNum = string.Concat(Number.Text, "3");
                    Number.Text = newNum;
                    Console.WriteLine("Three");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "4":
                    newNum = string.Concat(Number.Text, "4");
                    Number.Text = newNum;
                    Console.WriteLine("Four");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "5":
                    newNum = string.Concat(Number.Text, "5");
                    Number.Text = newNum;
                    Console.WriteLine("Five");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "6":
                    newNum = string.Concat(Number.Text, "6");
                    Number.Text = newNum;
                    Console.WriteLine("Six");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "7":
                    newNum = string.Concat(Number.Text, "7");
                    Number.Text = newNum;
                    Console.WriteLine("Seven");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "8":
                    newNum = string.Concat(Number.Text, "8");
                    Number.Text = newNum;
                    Console.WriteLine("Eight");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "9":
                    newNum = string.Concat(Number.Text, "9");
                    Number.Text = newNum;
                    Console.WriteLine("Nine");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "0":
                    newNum = string.Concat(Number.Text, "0");
                    Number.Text = newNum;
                    Console.WriteLine("Zero");
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "+":
                    Console.WriteLine("Plus");
                    equation = equation + Number.Text + "+";
                    Number.Text = "";
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "-":
                    Console.WriteLine("Minus");
                    equation = equation + Number.Text + "-";
                    Number.Text = "";
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "x":
                    Console.WriteLine("Multiplied by");
                    equation = equation + Number.Text + "*";
                    Number.Text = "";
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "÷":
                    Console.WriteLine("Divided by");
                    equation = equation + Number.Text + "/";
                    Number.Text = "";
                    Equate.Text = equation;
                    Console.WriteLine(equation);
                    break;
                case "=":
                    DataTable dt = new DataTable();
                    equation += Number.Text;
                    Console.WriteLine(equation);
                    Equate.Text = dt.Compute(equation, "").ToString();
                    Number.Text = "";
                    break;
                case "CE":
                    Number.Text = "";
                    equation = "";
                    Equate.Text = equation;
                    break;
            }
        }

        private void btnDark_Clicked(object sender, EventArgs e)
        {
            //Intended to switch to Dark Mode
        }
    }
}
