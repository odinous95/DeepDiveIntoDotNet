using LearningApp.Models;

public class PlayersRepository : IPlayersRepository
{
    private static readonly List<Player> players = new();

    public void AddPlayer(Player? player)
    {
        if (player != null)
        {
            players.Add(player);
        }
    }

    public Player GetPlayerById(int id)
    {
        return players.FirstOrDefault(p => p.Id == id);
    }

    public List<Player> GetPlayers()
    {
        return new List<Player>(players);
    }
}