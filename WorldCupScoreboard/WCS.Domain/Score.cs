namespace WCS.Domain;

public class Score
{
    public int ScoreValue { get; private set; }

    public Score(int scoreValue)
    {
        if (scoreValue < 0)
        {
            throw new ArgumentException("Score can't be negative");
        }
        
        ScoreValue = scoreValue;
    }
}