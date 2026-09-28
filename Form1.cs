using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        bool click = false;
        double resultValue = 0;
        string operationPerformed = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendNumber(string number)
        {
            if (click || richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
                click = false;
            }
            richTextBox1.Text += number;
        }

        private void button1_Click(object sender, EventArgs e) { AppendNumber("1"); }
        private void button2_Click(object sender, EventArgs e) { AppendNumber("2"); }
        private void button4_Click(object sender, EventArgs e) { AppendNumber("3"); }
        private void button3_Click(object sender, EventArgs e) { AppendNumber("4"); }
        private void button6_Click(object sender, EventArgs e) { AppendNumber("5"); }
        private void button5_Click(object sender, EventArgs e) { AppendNumber("6"); }
        private void button9_Click(object sender, EventArgs e) { AppendNumber("7"); }
        private void button8_Click(object sender, EventArgs e) { AppendNumber("8"); }
        private void button7_Click(object sender, EventArgs e) { AppendNumber("9"); }
        private void button10_Click(object sender, EventArgs e) { AppendNumber("0"); }

        private void button12_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "0";
                click = false;
            }
            if (!richTextBox1.Text.Contains(","))
            {
                richTextBox1.Text += ",";
            }
        }

        private void SetOperation(string op)
        {
            if (double.TryParse(richTextBox1.Text, out double val))
            {
                resultValue = val;
                operationPerformed = op;
                click = true;
            }
        }

        private void button18_Click(object sender, EventArgs e) { SetOperation("+"); }
        private void button20_Click(object sender, EventArgs e) { SetOperation("-"); }
        private void button16_Click(object sender, EventArgs e) { SetOperation("*"); }
        private void button17_Click(object sender, EventArgs e) { SetOperation(":"); }
        private void button14_Click(object sender, EventArgs e) { SetOperation("%"); }

        private void button15_Click(object sender, EventArgs e)
        {
            if (double.TryParse(richTextBox1.Text, out double val))
            {
                richTextBox1.Text = (val * val).ToString();
                click = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(richTextBox1.Text, out double currentValue))
                return;

            switch (operationPerformed)
            {
                case "+":
                    richTextBox1.Text = (resultValue + currentValue).ToString();
                    break;
                case "-":
                    richTextBox1.Text = (resultValue - currentValue).ToString();
                    break;
                case "*":
                    richTextBox1.Text = (resultValue * currentValue).ToString();
                    break;
                case ":":
                    if (currentValue != 0)
                        richTextBox1.Text = (resultValue / currentValue).ToString();
                    else
                        richTextBox1.Text = "0-a bölmək olmaz";
                    break;
                case "%":
                    richTextBox1.Text = (resultValue * currentValue / 100).ToString();
                    break;
            }
            operationPerformed = "";
            click = true;
        }
    }
}