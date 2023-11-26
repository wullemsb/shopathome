using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/hello", ([FromHeader(Name= "X-MS-CLIENT-PRINCIPAL")] string? token) =>
{
    //decode base64 token
    if(token is not null)
    {
        var decodedToken = Convert.FromBase64String(token);
        var decodedString = Encoding.UTF8.GetString(decodedToken);
        // var tokenObject = JsonSerializer.Deserialize<Dictionary<string, string>>(decodedString);
        // var name = tokenObject["userDetails"];
        return $"hello world - {decodedString}";
    }

    return $"hello world-{token}";
})
.WithName("GetHello")
.WithOpenApi();

app.Run();
