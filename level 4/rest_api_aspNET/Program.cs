// Minimal API (.NET 6+)

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello API");

app.Run();