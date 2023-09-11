using Microsoft.VisualBasic;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            decimal ans = 0;
            switch (operator1)
            {
                case "+":
                    ans = operand1 + operand2;
                    break;
                case "-":
                    ans = operand1 - operand2;
                    break;
                case "*":
                    ans = operand1 * operand2;
                    break;
                case "/":
                    ans = operand1 / operand2;
                    break;
            }
            return ans;


        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {

                    decimal opnd1 = Convert.ToDecimal(txtOperand1.Text);
                    decimal opnd2 = Convert.ToDecimal(txtOperand2.Text);
                    decimal ans = Calculate(opnd1, txtOperator.Text, opnd2);
                    txtResult.Text = ans.ToString("f4");
                    txtOperand1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n";
            }
            return msg;
        }
        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }
            return msg;
        }
        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " +
                    min + " and " + max + ".\n";
                }
            }
            return msg;
        }
        private string IsOperator(string value)
        {
            string msg = "";
            if (value != "+" && value != "-" && value != "*" && value != "/" && value != "%")
            {
                msg = "Operator must be +,-,*,/";
            }
            return msg;
        }
        private string IsValidOperation(string opertor, string operand)
        {
            string msg = "";
            decimal opnd2 = Convert.ToDecimal(operand);
            if (opnd2 == 0 && opertor == "/")
            {
                msg = "Divide by zero exception. Enter a non zero number.";
            }
            return msg;
        }
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            // Validate the Operand 1 text box
            errorMessage += IsDecimal(txtOperand1.Text, "Operand 1");
            errorMessage += IsWithinRange(txtOperand1.Text, "Operand 1", 0, 1000000);

            // Validate the Operand 2 text box
            errorMessage += IsDecimal(txtOperand2.Text, "Operand 2");
            errorMessage += IsWithinRange(txtOperand2.Text, "Operand 2", 0, 1000000);

            errorMessage += IsOperator(txtOperator.Text);
            errorMessage += IsValidOperation(txtOperator.Text, txtOperand2.Text);
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
                success = false;
            }
            return success;
        }
    }
}