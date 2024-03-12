using FluentAssertions;

namespace WCS.Domain.Tests;

public partial class TeamSpecs
{
    public Action CreateTeam { get; set; }
    private const string Name = "TeamName";
    private Team Team { get; set; }

    private void when_trying_to_create_team_with_name()
    {
        Team = new Team(Name);
    }

    private void when_trying_to_create_team_with_null()
    {
        CreateTeam = () => _ = new Team(null);
    }

    private void when_trying_to_create_team_with_empty_string()
    {
        CreateTeam = () => _ = new Team("");
    }

    private void when_trying_to_create_team_with_more_than_one_hundred_symbols()
    {
        CreateTeam = () => _ = new Team(new string('*', 101));
    }

    private void then_created_team_should_have_this_name()
    {
        Team.Name.Should().Be(Name);
    }
    
    private void then_fails_with_message(string nameShouldBeProvided)
    {
        CreateTeam.Should().Throw<ArgumentException>().WithMessage(nameShouldBeProvided);
    }
}