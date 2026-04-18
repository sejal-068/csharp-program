builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = "localhost:6379";
});

app.MapGet("/data", async (IDistributedCache cache) =>
{
    var data = await cache.GetStringAsync("key");
    if (data == null)
    {
        data = "Fresh Data";
        await cache.SetStringAsync("key", data);
    }
    return data;
});