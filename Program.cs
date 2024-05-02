var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello awdawwWoawdasdasdsdawdrld for master branch");

app.Run();
