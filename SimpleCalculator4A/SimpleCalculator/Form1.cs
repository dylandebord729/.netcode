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
                decimal opnd1 = Convert.ToDecimal(txtOperand1.Text);
                decimal opnd2 = Convert.ToDecimal(txtOperand2.Text);
                decimal ans = Calculate(opnd1, txtOperator.Text, opnd2);
                txtResult.Text = ans.ToString("f4");
                txtOperand1.Focus();
            }
            catch (DivideByZeroException) // another specific exception
            {
                MessageBox.Show(
                "Divide by zero exception. Enter a non zero number.",
                "Entry Error");
            }
            catch (OverflowException) // another specific exception
            {
                MessageBox.Show(
                "Overflow exception. Enter smaller values.",
                "Entry Error");
            }

            catch (FormatException) // a specific exception
            {
                MessageBox.Show(
                "A format exception has occurred. Check entries.",
                "Entry Error");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
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
    }
}