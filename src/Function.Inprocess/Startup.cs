using Azure.Identity;
using Function_Inprocess;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using Functions.KeyVault;

[assembly: WebJobsStartup(typeof(Startup))]
namespace Function_Inprocess
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
        }

        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            builder.ConfigurationBuilder.AddKeyvaultConfiguration();
        }
    }
}
