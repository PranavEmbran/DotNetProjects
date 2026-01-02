var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root path");
app.MapGet("/dash", () => "Dashboard");

app.Run();
