using Microsoft.VisualBasic.Devices;

namespace BasicCalculator
{
    public partial class Calculator : Form
    {
        string num1 = "";
        string num2 = "";
        string oper = "";
        public Calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            if (newNumber != "0")
            {
                newNumber += "0";
                txtNumber.Text = newNumber;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "1";
            txtNumber.Text = newNumber;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "2";
            txtNumber.Text = newNumber;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "3";
            txtNumber.Text = newNumber;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "4";
            txtNumber.Text = newNumber;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "5";
            txtNumber.Text = newNumber;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "6";
            txtNumber.Text = newNumber;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "7";
            txtNumber.Text = newNumber;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "8";
            txtNumber.Text = newNumber;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber += "9";
            txtNumber.Text = newNumber;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = txtNumber.Text;
            oper = "+";
            txtNumber.Text = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            num1 = txtNumber.Text;
            oper = "-";
            txtNumber.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = txtNumber.Text;
            oper = "*";
            txtNumber.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = txtNumber.Text;
            oper = "/";
            txtNumber.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (num2 == "")
            {
                num2 = txtNumber.Text;
            }
            else {
                num1 = txtNumber.Text;
                    }
            string newNum = "";
            decimal opnd1 = Convert.ToDecimal(num1);
            decimal opnd2 = Convert.ToDecimal(num2);
            decimal ans = 0;
            try
            {
              switch (oper)
               {
                  case "+":
                    ans = opnd1 + opnd2;
                    break;
                  case "-":
                    ans = opnd1 - opnd2;
                    break;
                  case "*":
                    ans = opnd1 * opnd2;
                    break;
                  case "/":
                    ans = opnd1 / opnd2;
                    break;
              }
              txtNumber.Text = ans.ToString();
                }
             catch (DivideByZeroException)
             {
              txtNumber.Text = "Div by 0";
             }
        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            string newNum = txtNumber.Text;
            if (newNum[0] == '-')
            {
                newNum = newNum.Substring(1, newNum.Length -1);
            }
            else 
            { 
                newNum = "-" + txtNumber.Text;
            }
            txtNumber.Text = newNum;
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            if (newNumber.Contains(".") == false)
            {
                newNumber += ".";
                txtNumber.Text = newNumber;
            }
        }

        private void btnsqr_Click(object sender, EventArgs e)
        {
            num1 = txtNumber.Text;
            double newNum = Math.Sqrt(Convert.ToDouble(num1));
            txtNumber.Text = Convert.ToString(newNum);
        }

        private void btndivide1_Click(object sender, EventArgs e)
        {
            num1 = txtNumber.Text;
            double newNum = 1 / (Convert.ToDouble(num1));
            txtNumber.Text = Convert.ToString(newNum);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string newNumber = txtNumber.Text;
            newNumber = newNumber.Substring(0, newNumber.Length - 1);
            txtNumber.Text = newNumber;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            oper = "";
            num1 = "";
            num2 = "";
        }
    }

}