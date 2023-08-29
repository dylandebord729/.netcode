namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        int scoreTotal = 0;
        int scoreCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt16(txtScore.Text);
            scoreTotal += score;
            scoreCount++;
            int average = scoreTotal / scoreCount;
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = average.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Text = "";
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

    }
}