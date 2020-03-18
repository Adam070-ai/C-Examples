using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
                
        }
        double resultValue = 0;
        string operatinonPerformed = "";
        bool isOperationPerformed = false;

        private void Button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
            {
                textBox_Result.Clear();
            }
            Button button = (Button)sender;
            if (textBox_Result.Text==".")
            {
                if (!button.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
            isOperationPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue!=0 )
            {
                btnEsittir.PerformClick();
                operatinonPerformed = button.Text;
                isOperationPerformed = true;
                labelOperation.Text = resultValue + " " + operatinonPerformed;
            }
            else
            operatinonPerformed = button.Text;
            resultValue = double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
            labelOperation.Text = resultValue + " " + operatinonPerformed;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            labelOperation.Text = "0";
        }

        private void btnTumunuSil_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            switch (operatinonPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox_Result.Text);
            labelOperation.Text = "";  
        }

        private void btnGeriAlma_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
        }
    }
}
