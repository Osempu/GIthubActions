using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");
app.MapGet("time/utc", () => Results.Ok(DateTime.UtcNow));

app.Run();
