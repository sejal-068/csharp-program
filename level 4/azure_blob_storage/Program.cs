using Azure.Storage.Blobs;

var client = new BlobServiceClient("connection_string");
var container = client.GetBlobContainerClient("mycontainer");

await container.UploadBlobAsync("file.txt", File.OpenRead("file.txt"));