using KlasDemoKlasDiagrammen3.Core;

namespace KlasDemoKlasDiagrammen3.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person1 = new("Jos",13);
            Person person2 = new("Jose",13);
            GameCompany gameCompany1 = new GameCompany("GC1","B");
            GameCompany gameCompany2 = new GameCompany("GC2","JPN");
            Game game1 = new("Game 1",new DateTime(2026,11,111));
            Game game2 = new("Game 2",new DateTime(2026,9,111));
            game1.AddPlayer(person1);
            game2.AddPlayer(person2);
            gameCompany1.AddGame(game1);
            gameCompany2.AddGame(game2);
            Console.WriteLine(gameCompany1.GetCompanyInformation());
            Console.WriteLine(gameCompany2.GetCompanyInformation());



        }
    }
}
