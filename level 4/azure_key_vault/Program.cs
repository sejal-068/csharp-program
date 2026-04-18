using Azure.Security.KeyVault.Secrets;
using Azure.Identity;

var client = new SecretClient(
    new Uri("https://yourvault.vault.azure.net/"),
    new DefaultAzureCredential());

KeyVaultSecret secret = client.GetSecret("MySecret");

Console.WriteLine(secret.Value);