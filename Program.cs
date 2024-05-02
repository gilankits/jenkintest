var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Woawdasdasdsdawdrld for master branch");

app.Run();
