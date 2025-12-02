
namespace LearningApp.Models
{
    public interface IPlayersRepository
    {
        void AddPlayer(Player? player);
        Player GetPlayerById(int id);
        List<Player> GetPlayers();
    }
}