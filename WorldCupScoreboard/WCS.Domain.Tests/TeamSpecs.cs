using NUnit.Framework;

namespace WCS.Domain.Tests;

[TestFixture]
public partial class TeamSpecs
{
    [Test]
    public void team_should_have_corresponding_name()
    {
        when_trying_to_create_team_with_name();
        then_created_team_should_have_this_name();
    }

    [Test]
    public void team_name_should_be_provided()
    {
        when_trying_to_create_team_with_null();
        then_fails_with_message("Name should be provided");
    }
    
    [Test]
    public void team_name_should_not_be_an_empty_string()
    {
        when_trying_to_create_team_with_empty_string();
        then_fails_with_message("Name should not be empty");
    }
    
    [Test]
    public void team_name_should_not_longer_than_one_hundred_symbols()
    {
        when_trying_to_create_team_with_more_than_one_hundred_symbols();
        then_fails_with_message("Name should not be longer than 100 symbols");
    }
}