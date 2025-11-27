using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasDemoKlasDiagrammen3.Core
{
    public class Game
    {
        public string  Name { get; }
        public DateTime ReleaseDate { get; }
        public List<Person> Players { get; }
        public Game(string name, DateTime releaseDate)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Players = [];
        }
        public void AddPlayer(Person person)
        {
            if(Players.Contains(person)){
                throw new ArgumentException("Player already added.");
            }
            Players.Add(person);
        }
        public override string ToString()
        {
            return $"Game: {Name}, Released on: {ReleaseDate:d}, Players: {string.Join(", ",Players.Select(p => p.Name))}";
        }
    }
}
