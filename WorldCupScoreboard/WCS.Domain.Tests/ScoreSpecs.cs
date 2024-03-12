using NUnit.Framework;

namespace WCS.Domain.Tests;

public partial class ScoreSpecs
{
    [Test]
    public void score_should_have_corresponding_score_value()
    {
        when_trying_to_create_score_with_score_value();
        then_created_team_should_have_this_score_value();
    }
    
    [Test]
    public void score_can_not_be_negative()
    {
        when_trying_to_create_score_with_negative_number();
        then_fails_with_message("Score can't be negative");
    }
}