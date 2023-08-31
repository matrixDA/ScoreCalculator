namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        int count = 0;

        int average = 0;

        int score;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //score = 0;
           int  score2 = Convert.ToInt32(txtScore.Text);

            score += score2;

            txtScoreTotal.Text = score.ToString();
            count++;

            txtScoreCount.Text = count.ToString();


            average = score / count;
            txtAverage.Text = average.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScore.Clear();
            txtAverage.Clear();
            txtScoreCount.Clear();
            txtScoreTotal.Clear();
        }
    }
}