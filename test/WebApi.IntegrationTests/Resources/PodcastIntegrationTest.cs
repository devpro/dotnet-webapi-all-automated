using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture;
using Devpro.Examples.WebApiAllAutomated.WebApi.Dto;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Withywoods.Serialization.Json;
using Xunit;

namespace Devpro.Examples.WebApiAllAutomated.WebApi.IntegrationTests.Resources
{
    [Trait("Category", "IntegrationTests")]
    public class PodcastIntegrationTest : ResourceBase
    {
        private const string ResourceEndpoint = "podcast";

        public PodcastIntegrationTest(WebApplicationFactory<Startup> factory)
            : base(factory)
        {
        }

        [Fact]
        [Trait("Mode", "Readonly")]
        public async Task OfficeUserResource_FindOneById_ReturnsOk()
        {
            var id = "1234";
            var url = $"/{ResourceEndpoint}/{id}";

            var output = await GetAsync<PodcastDto>(url);
            output.Should().NotBeNull();
            output.Id.Should().Be(id);
        }

        [Fact]
        [Trait("Mode", "Readonly")]
        public async Task OfficeUserResource_FindAll_ReturnsOk()
        {
            var url = $"/{ResourceEndpoint}";

            var users = await GetAsync<List<PodcastDto>>(url);
            users.Should().NotBeNull();
            users.Count.Should().BeGreaterThan(1);
        }

        [Fact]
        public async Task OfficeUserResource_Create_ReturnsOk()
        {
            var url = $"/{ResourceEndpoint}";

            var dto = Fixture.Create<PodcastDto>();
            dto.Id = null;

            var output = await PostAsync<PodcastDto>(url, dto.ToJson());
            output.Should().NotBeNull();
            output.Id.Should().NotBeNullOrEmpty();
        }
    }
}
