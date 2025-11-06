var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Yeni tag verildi mi? Evet başarılı.");

app.Run("http://0.0.0.0:9080");
