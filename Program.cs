var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!1111test  woaadawsdasdrking");

app.Run();
