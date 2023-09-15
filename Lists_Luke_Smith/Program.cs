namespace Lists_Luke_Smith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates a string list titled games that contains five games
            List<string> games = new List<string> { "Minecraft", "BotW", "TotK", "Rimworld" };
            //creates a string array titled otherGames that contains three games
            String[] otherGames = new String[] { "Halo", "CoD", "PUBG" };
            //prints all the games to the console
            foreach (String game in games) { Console.WriteLine(game); }
            //prints the number of games to the console
            Console.WriteLine(games.Count);
            //adds the games in otherGames to games
            games.AddRange(otherGames);
            //prints the number of games to the console
            Console.WriteLine(games.Count);
            //if Halo is in the list prints the writing in quotes
            if (games.Contains("Halo")) { Console.WriteLine("MASTER CHIEF is in the house"); }
            //adds Halo if it isn't already there
            else { games.Add("Halo"); }
            //creates a new int called myInt with a value of 6
            int myInt = 6;
            //checks if the number of games is larger than myInt if it is it removes the sixth value from games
            if (games.Count > myInt) { games.RemoveAt(6); }
            //prints "Game not found!" if there are less than 6 games
            else { Console.WriteLine("Game not found!"); }
            //prints "All games on list:" to the console
            Console.WriteLine("All games on list:");
            //prints all the games in games
            foreach (String game in games) { Console.WriteLine(game); }
            //sorts games
            games.Sort();
            //prints "Sorted Games List:" to the console
            Console.WriteLine("Sorted Games List:");
            //prints all the games in games
            foreach (String game in games) { Console.WriteLine(game); }
            //creates a new string array with a size of 6
            String[] newList = new String[6];
            //copies the contents of games to newList
            games.CopyTo(newList, 0);
            //clears the contents of games
            games.Clear();
            //prints the contents of newList
            foreach(String game in newList) { Console.WriteLine(game); }
        }
    }
}