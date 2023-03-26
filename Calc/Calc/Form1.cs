using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    
    public partial class Form1 : Form
    {
        bool isoperationperformed=false;
        double resultvalue = 0;
        string operationperformed = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            if (Textbox_Result.Text == "0" || (isoperationperformed==true))
            {
                Textbox_Result.Clear();
            }
            isoperationperformed = false;
            Button button1 = (Button)sender;

            if (button1.Text == ".")
            {
                if (!Textbox_Result.Text.Contains("."))
                
                    Textbox_Result.Text = Textbox_Result.Text + button1.Text;
            }
            else
                Textbox_Result.Text = Textbox_Result.Text + button1.Text;
            
        }

        private void click_operator(object sender, EventArgs e)
        {
           
            Button button2 = (Button)sender;

            if (resultvalue != 0)
            {
                button16.PerformClick();

                operationperformed = button2.Text;
                label1.Text = resultvalue + " " + operationperformed;

                isoperationperformed = true;
            }
            operationperformed = button2.Text;
            resultvalue = double.Parse(Textbox_Result.Text);
            label1.Text = resultvalue + " " + operationperformed;

            isoperationperformed = true;
        }
        private void clear_btn(object sender, EventArgs e)
        {
            label1.Text = "";
            isoperationperformed = false;
            Textbox_Result.Text = "0";
            resultvalue = 0;
        }

        private void check_btn(object sender, EventArgs e)
        {
            Textbox_Result.Text = "0";   
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = resultvalue + " " + operationperformed + " " + double.Parse(Textbox_Result.Text);
            switch (operationperformed)
            {
                case "+":
                    Textbox_Result.Text = (resultvalue + (double.Parse(Textbox_Result.Text))).ToString();
                    break;
                case "-":
                    Textbox_Result.Text = (resultvalue - (double.Parse(Textbox_Result.Text))).ToString();
                    break;
                case "*":
                    Textbox_Result.Text = (resultvalue * (double.Parse(Textbox_Result.Text))).ToString();
                    break;
                case "/":
                    Textbox_Result.Text = (resultvalue / (double.Parse(Textbox_Result.Text))).ToString();
                    break;
                case "%":
                    Textbox_Result.Text = (resultvalue % (double.Parse(Textbox_Result.Text))).ToString();
                    break;
            }
            resultvalue = 0;
        }

    }
}
