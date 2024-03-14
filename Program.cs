var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World hkjhkjhkjhzdfsdfsf");

app.Run();
