using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasDemoKlasDiagrammen3.Core
{
    public class GameCompany : Company
    {
        public GameCompany(string name,string country) : base(name,country)
        {
            Games = [];
        }

        public List<Game> Games { get; }
        public void AddGame(Game game)
        {
            if(Games.Contains(game))
            {
                throw new ArgumentException("Game already exists.");
            }
            Games.Add(game);
        }
        public override string GetCompanyInformation()
        {
            string output = $"Game Company: {Name}, Country: {Country}\nGames:";
            Games.ForEach(g => output += $"\n - {g}");
            return output;
        }
    }
}
