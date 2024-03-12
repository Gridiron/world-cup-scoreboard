using FluentAssertions;

namespace WCS.Domain.Tests;

public partial class ScoreSpecs
{
    private const int ScoreValue = 1;
    private Score Score { get; set; }
    private Action CreateScore { get; set; }

    private void when_trying_to_create_score_with_score_value()
    {
        Score = new Score(ScoreValue);
    }
    
    private void when_trying_to_create_score_with_negative_number()
    {
        CreateScore = () => _ = new Score(-1);
    }
    
    private void then_created_team_should_have_this_score_value()
    {
        Score.ScoreValue.Should().Be(ScoreValue);
    }

    private void then_fails_with_message(string message)
    {
        CreateScore.Should().Throw<ArgumentException>().WithMessage(message);
    }
}