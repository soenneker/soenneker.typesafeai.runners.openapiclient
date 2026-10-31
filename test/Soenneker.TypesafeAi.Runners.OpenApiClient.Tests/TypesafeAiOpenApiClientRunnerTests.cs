using Soenneker.Tests.HostedUnit;

namespace Soenneker.TypesafeAi.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TypesafeAiOpenApiClientRunnerTests : HostedUnitTest
{
    public TypesafeAiOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
