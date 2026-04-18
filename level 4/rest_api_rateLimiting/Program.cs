builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("limit", opt =>
    {
        opt.PermitLimit = 5;
        opt.Window = TimeSpan.FromSeconds(10);
    });
});

app.UseRateLimiter();

app.MapGet("/", () => "Rate Limited").RequireRateLimiting("limit");