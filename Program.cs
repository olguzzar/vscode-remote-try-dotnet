var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// See if we keep this with HTTPS
app.Urls.Add("http://localhost:3000");

app.MapGet("/", () => "Hello All Things Open!");

app.Run();
