using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Messages.MsTeams.Tests;

[Collection("Collection")]
public class MsTeamsMessageTests : FixturedUnitTest
{
    public MsTeamsMessageTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
