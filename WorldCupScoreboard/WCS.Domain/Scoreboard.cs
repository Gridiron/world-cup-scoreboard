namespace WCS.Domain;

public class Scoreboard : IScoreboard
{
    public void StartMatch(Team homeTeam, Team awayTeam)
    {
        throw new NotImplementedException();
    }

    public void UpdateScore(Score homeTeamScore, Score awayTeamScore)
    {
        throw new NotImplementedException();
    }

    public void FinishMatch(Match match)
    {
        throw new NotImplementedException();
    }

    public ScoreboardSummary GetSummary()
    {
        throw new NotImplementedException();
    }
}

public interface IScoreboard
{
    void StartMatch(Team homeTeam, Team awayTeam);
    void UpdateScore(Score homeTeamScore, Score awayTeamScore);
    void FinishMatch(Match match);
    ScoreboardSummary GetSummary();

}