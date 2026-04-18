builder.Services.AddDbContext<AppDbContext>();

app.MapGet("/students", (AppDbContext db) => db.Students.ToList());