using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Devpro.Examples.WebApiAllAutomated.WebApi.IntegrationTests.Resources
{
    [Trait("Category", "IntegrationTests")]
    public class HealthCheckIntegrationTest : ResourceBase
    {
        private const string ResourceEndpoint = "health";

        public HealthCheckIntegrationTest(WebApplicationFactory<Startup> factory)
            : base(factory)
        {
        }

        [Fact]
        [Trait("Mode", "Readonly")]
        public async Task HealthCheckResource_Get_ReturnsOk()
        {
            var url = $"/{ResourceEndpoint}";

            var output = await GetAsync(url);
            output.Should().NotBeNull();
            output.Should().Be("Healthy");
        }
    }
}
