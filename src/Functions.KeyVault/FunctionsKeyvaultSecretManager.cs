using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Extensions.Configuration;

namespace Functions.KeyVault
{
    internal class FunctionsKeyvaultSecretManager : KeyVaultSecretManager
    {
        public override bool Load(SecretProperties secret)
        {
            return secret.Enabled.GetValueOrDefault();
        }

        public override string GetKey(KeyVaultSecret secret)
        {
            return secret.Name.Replace("--", ConfigurationPath.KeyDelimiter);
        }
    }
}
