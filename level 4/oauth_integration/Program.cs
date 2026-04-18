builder.Services.AddAuthentication()
    .AddGoogle(options =>
    {
        options.ClientId = "your-client-id";
        options.ClientSecret = "your-secret";
    });

app.UseAuthentication();