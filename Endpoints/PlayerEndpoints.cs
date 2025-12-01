using LearningApp.Models;

namespace LearningApp.Endpoints
{
    public static class PlayerEndpoints
    {
            public static void MapPlayerEndpoints(this WebApplication app)
            {
                  app.MapGet("/players/{id:int}", (int id) =>
                  {
                      Player player = PlayersRepositoryInMomoeryDB.GetPlayerById(id);
                      return player is not null
                          ? TypedResults.Ok(player)
                          : Results.ValidationProblem(new Dictionary<string, string[]>
                          {
                { "id", new[] { $"Player with the id {id} does not exists" } }
                          });
                  });

                app.MapGet("/players", () =>
                {
                    List<Player> players = PlayersRepositoryInMomoeryDB.GetPlayers();
                    return players is not null
                        ? TypedResults.Ok(players)
                        : Results.ValidationProblem(new Dictionary<string, string[]>
                    {
                { "players", new [] { "Players do not exist!" } }
                        });
                });
            }
    }
}


