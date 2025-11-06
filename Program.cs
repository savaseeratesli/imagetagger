var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Yeni tag verildi mi?");

app.Run("http://0.0.0.0:9080");
