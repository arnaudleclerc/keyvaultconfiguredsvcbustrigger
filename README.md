Note : [Issue](https://github.com/Azure/azure-functions-dotnet-worker/issues/2206) has been closed and this repository has been archived. 

# ServiceBus Trigger on Azure Functions isolated and in-process mode with connection and queue name coming from the keyvault

This repository tries to make the ServiceBusTrigger of an Azure Function on isolated mode run with a connection and queue name coming from an Azure Key Vault.

This behavior works fine with the in-process mode.

There a 3 projects in this repository : 

- `Functions.KeyVault` : A library sharing an extension method to add the Key Vault into the configuration sources
- `Functions.InProcess` : An azure function running on in-process mode having a ServiceBusTrigger.
- `Functions.Isolated` : An azure function running on isolated mode having a ServiceBusTrigger.

Both function add the keyvault configuration into the configuration sources.

The connection to ServiceBus is done via Managed Identity. The secret on the keyvault to connect to the service bus is the fully qualified namespace of the service bus instance formatted as `ServiceBusNamespace:fullyQualifiedNamespace` as documented [here](https://learn.microsoft.com/en-us/azure/azure-functions/functions-bindings-service-bus-trigger?tabs=python-v2%2Cisolated-process%2Cnodejs-v4%2Cextensionv5&pivots=programming-language-csharp#identity-based-connections).

The trigger works fine on the in-process Azure Function. The trigger on the isolated one does not find the configuration.
