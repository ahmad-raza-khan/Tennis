using static System.Formats.Asn1.AsnWriter;

namespace Tennis.Game
{
    public class TennisGame : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;
        private readonly string love = "Love";
        private readonly string fifteen = "Fifteen";
        private readonly string thirty = "Thirty";
        private readonly string forty = "Forty";
        private readonly string deuce = "Deuce";
        private readonly string advantage = "Advantage";
        private readonly string winfor = "Win for";
        private readonly string all = "All";
        public TennisGame(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == $"{player1Name}")
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {                
            if (m_score1 == m_score2)            
                return PointsEqualScore();            
            else if (m_score1 >= 4 || m_score2 >= 4)            
                return MatchTowardEndScore();            
            else            
                return PointsUnequalScore();               
        }

        string PointsEqualScore()
        {
            string score = "";

            switch (m_score1)
            {
                case 0:
                    score = $"{love}-{all}"; break;
                case 1:
                    score = $"{fifteen}-{all}"; break;
                case 2:
                    score = $"{thirty}-{all}"; break;
                default:
                    score = $"{deuce}"; break;
            }
            return score;
        }
        string MatchTowardEndScore()
        {
            string score = "";
            int minusResult = m_score1 - m_score2;

            if (minusResult == 1) 
                score = $"{advantage} {player1Name}";
            else if (minusResult == -1)
                score = $"{advantage} {player2Name}";
            else if (minusResult >= 2)
                score = $"{winfor} {player1Name}";
            else
                score = $"{winfor} {player2Name}";
           
            return score;
        }
        string PointsUnequalScore()
        {
            string score = "";
            int tempScore = 0;           

            for (int i = 1; i < 3; i++)
            {
                if (i == 1) 
                    tempScore = m_score1;
                else 
                { 
                    score += "-";
                    tempScore = m_score2;
                }

                switch (tempScore)
                {
                    case 0:
                        score += $"{love}"; break;
                    case 1:
                        score += $"{fifteen}"; break;
                    case 2:
                        score += $"{thirty}"; break;
                    case 3:
                        score += $"{forty}"; break;
                }                
            }
            return score;
        }
    }
}
