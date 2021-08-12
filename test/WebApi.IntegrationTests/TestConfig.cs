using System;

namespace Devpro.Examples.WebApiAllAutomated.WebApi.IntegrationTests
{
    public class TestConfig
    {
        public static bool IsLocalhostEnvironment => bool.Parse(GetEnvironmentVariableOrDefault("IsLocalhostEnvironment", true.ToString()));

        public static string ApiUrl => GetEnvironmentVariableOrDefault("ApiUrl", null);

        private static string GetEnvironmentVariableOrDefault(string environmentVariableName, string defaultValue)
        {
            var environmentVariableValue = Environment.GetEnvironmentVariable("IsLocalhostEnvironment");
            if (string.IsNullOrEmpty(environmentVariableValue))
            {
                return defaultValue;
            }

            return environmentVariableValue;
        }
    }
}
