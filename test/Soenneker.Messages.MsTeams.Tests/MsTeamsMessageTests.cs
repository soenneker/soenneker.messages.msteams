using Soenneker.Tests.HostedUnit;

namespace Soenneker.Messages.MsTeams.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class MsTeamsMessageTests : HostedUnitTest
{
    public MsTeamsMessageTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
