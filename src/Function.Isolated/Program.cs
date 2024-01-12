using Functions.KeyVault;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureHostConfiguration(builder => builder.AddKeyvaultConfiguration())
    .Build();

host.Run();
