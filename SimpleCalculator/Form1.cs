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
            decimal opnd1 = Convert.ToDecimal(txtOperand1.Text);
            decimal opnd2 = Convert.ToDecimal(txtOperand2.Text);
            decimal ans = Calculate(opnd1, txtOperator.Text, opnd2);
            txtResult.Text = ans.ToString("f4");
            txtOperand1.Focus();
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