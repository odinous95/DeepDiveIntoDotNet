
using LearningApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
// Middleware 
app.UseRouting();


app.UseEndpoints(static endpoints =>
{
    _ = endpoints.MapGet("/players/{id:int}", (int id) =>
    {
        Player player = PlayersRepositoryInMomoeryDB.GetPlayerById(id);
        return player is not null
            ? TypedResults.Ok(player)
            : Results.ValidationProblem(new Dictionary<string, string[]>
            {
                { "id", new[] { $"Player with the id {id} does not exists" } }
            });
    });
      
    _ = endpoints.MapGet("/player/{id:int}", (int id) =>
    {
        Player player = PlayersRepositoryInMomoeryDB.GetPlayerById(id);
        return player is not null ? TypedResults.Ok(player) : Results.ValidationProblem(new Dictionary<string, string[]>
        {
            {"id", new[] {$"Player with the id {id} does not exist "} }
    });
});
});

app.Run();