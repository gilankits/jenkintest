var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!1111asdadstest  workingsdsd1111");

app.Run();
