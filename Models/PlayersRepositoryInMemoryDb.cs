
namespace LearningApp.Models
{
    public static class PlayersRepositoryInMomoeryDB
    {
        private static List<Player> players = new List<Player>
    {
        new(1,"Ronaldo"),
        new(2,"David"),
        new(3,"Ozil"),
        new(4,"Salah")
    };
        public static List<Player> GetPlayers() => players;
        public static Player GetPlayerById(int id)
        {
            return players.FirstOrDefault(p => p.Id == id);
        }
        public static void AddPlayer(Player? player)
        {
            if (player is not null)
            {
                players.Add(player);
            }
        }
    }
}
