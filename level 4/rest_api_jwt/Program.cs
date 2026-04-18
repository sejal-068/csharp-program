// Simplified example

builder.Services.AddAuthentication("Bearer")
.AddJwtBearer("Bearer", options =>
{
    options.Authority = "https://example.com";
    options.Audience = "api";
});

app.UseAuthentication();
app.UseAuthorization();