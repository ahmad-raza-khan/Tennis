using Tennis.Game;
namespace Scoreboard
{
    public partial class Scoreboard : Form
    {
        private TennisGame? tennisGame = null;
        public Scoreboard()
        {            
            InitializeComponent();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            if (tennisGame != null)
            {
                tennisGame.WonPoint(txtPlayer1.Text);
                lblScore.Text = tennisGame.GetScore();
                if (lblScore.Text.Contains("Win"))
                    btnPlayer1.Enabled = btnPlayer2.Enabled = false;
            }
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            if (tennisGame != null)
            {
                tennisGame.WonPoint(txtPlayer2.Text);
                lblScore.Text = tennisGame.GetScore();
                if (lblScore.Text.Contains("Win"))
                    btnPlayer1.Enabled = btnPlayer2.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //do validations and then instantiate object 
            if ((txtPlayer1.Text == txtPlayer2.Text) || txtPlayer1.TextLength < 1 || txtPlayer2.TextLength < 1)
            {
                MessageBox.Show("Enter valid player names");
                return;
            }
            
            tennisGame = new TennisGame(txtPlayer1.Text, txtPlayer2.Text);

            btnPlayer2.Visible = btnPlayer1.Visible = true;
            btnStart.Visible = false;
        }
    }
}
