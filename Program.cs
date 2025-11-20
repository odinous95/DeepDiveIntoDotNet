using LearningApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();
// Middleware 
app.UseRouting();

app.UseEndpoints(static endpoints =>
{
    _ = endpoints.MapGet("/players/{id:int}",  ([AsParameters] PlayerParameterFromReq param) =>
    {
        Player player =  PlayersRepositoryInMomoeryDB.GetPlayerById(param.id);
        Console.WriteLine($"this is the position from query string {param.position}");
        Console.WriteLine(param.name);
        return player;
    });
});

app.Run();



struct PlayerParameterFromReq
{
    [FromRoute]
    [Required]
    public int id { get; set; }
    [FromHeader]
    public string name { get; set; }
    [FromQuery]
    public string position { get; set; }
};



