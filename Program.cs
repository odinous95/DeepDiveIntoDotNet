
using LearningApp.Endpoints;
using LearningApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IPlayersRepository, PlayersRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
}

app.MapPlayerEndpoints();

app.Run();