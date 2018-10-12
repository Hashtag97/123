using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        Calc calc;

        public Form1()
        {


            InitializeComponent();


            calc = new Calc();


            labelNumber.Text = "0";
        }

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }
        private bool CanPress()
        {
            if (!buttonMult.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonPlus.Enabled)
                return false;

            if (!buttonMinus.Enabled)
                return false;
            if (!buttonPow.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            buttonMult.Enabled = true;
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonPow.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
            calc.Clear_A();
            FreeButtons();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '0')
                labelNumber.Text = "0";
            else if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
                labelNumber.Text = calc.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDiv.Enabled)
                labelNumber.Text = calc.Division(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonPlus.Enabled)
                labelNumber.Text = calc.Sum(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonMinus.Enabled)
                labelNumber.Text = calc.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();
            if (!buttonPow.Enabled)
                labelNumber.Text = calc.DegreeY(Convert.ToDouble(labelNumber.Text)).ToString();


            calc.Clear_A();
            FreeButtons();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMult.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {

            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDiv.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPlus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMinus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = calc.Square().ToString();

                calc.Clear_A();
                FreeButtons();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = calc.Sqrt().ToString();

                calc.Clear_A();
                FreeButtons();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPow.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = calc.Sin().ToString();

                calc.Clear_A();
                FreeButtons();
            }
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = calc.Cos().ToString();

                calc.Clear_A();
                FreeButtons();
            }
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                calc.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = calc.Tag().ToString();

                calc.Clear_A();
                FreeButtons();
            }
        }
    }
}

