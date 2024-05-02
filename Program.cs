var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello asdasdasdasawdaawwWoawdasdasdsdawdrld for master branch");

app.Run();
