using Azure.Identity;
using Microsoft.Extensions.Configuration;

namespace Functions.KeyVault;

public static class Extensions
{
    public static IConfigurationBuilder AddKeyvaultConfiguration(this IConfigurationBuilder builder)
    {
        return builder.AddAzureKeyVault(
            new Azure.Security.KeyVault.Secrets.SecretClient(new Uri(Environment.GetEnvironmentVariable("KeyvaultUri")), new DefaultAzureCredential()),
            new FunctionsKeyvaultSecretManager());
    }
}
