using PortfolioBlazorApp.Models;

namespace PortfolioBlazorApp.Services;

public class PlayerService
{
    public List<HandballPlayerModel> GetPlayers()
    {
        return new List<HandballPlayerModel>
        {
            new HandballPlayerModel
            {
                FirstName = "Nikola",
                LastName = "Karabatic",
                Position = "Left Back"
            },
            new HandballPlayerModel
            {
                FirstName = "Mikkel",
                LastName = "Hansen",
                Position = "Left Back"
            },
            new HandballPlayerModel
            {
                FirstName = "Sander",
                LastName = "Sagosen",
                Position = "Center Back"
            },
            new HandballPlayerModel
            {
                FirstName = "Anders",
                LastName = "Eggert",
                Position = "Left Wing"
            }

        };
    }
}
