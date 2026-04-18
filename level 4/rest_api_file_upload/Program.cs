app.MapPost("/upload", async (IFormFile file) =>
{
    var path = Path.Combine("uploads", file.FileName);
    using var stream = File.Create(path);
    await file.CopyToAsync(stream);
    return "Uploaded";
});

app.MapGet("/download/{name}", (string name) =>
{
    var path = Path.Combine("uploads", name);
    return Results.File(path);
});