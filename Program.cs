var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/vulnerable", (string data) =>
                        {
                            Console.WriteLine($"Received data: {data}");
                            return "Received data";
                        });
app.Run();
