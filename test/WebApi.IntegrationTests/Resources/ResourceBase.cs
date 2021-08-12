using System;
using System.Net.Http;
using AutoFixture;
using Microsoft.AspNetCore.Mvc.Testing;
using Withywoods.WebTesting.Rest;
using Xunit;

namespace Devpro.Examples.WebApiAllAutomated.WebApi.IntegrationTests.Resources
{
    public abstract class ResourceBase : RestClient, IClassFixture<WebApplicationFactory<Startup>>
    {
        protected ResourceBase(WebApplicationFactory<Startup> factory)
            : base(TestConfig.IsLocalhostEnvironment ? factory.CreateClient() : new HttpClient { BaseAddress = new Uri(TestConfig.ApiUrl) })
        {
        }

        protected TestConfig Configuration { get; } = new TestConfig();

        protected Fixture Fixture { get; } = new Fixture();
    }
}
