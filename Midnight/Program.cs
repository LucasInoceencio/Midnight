using System;

namespace Midnight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Account example
            Console.WriteLine(Account.Access.Writer.HasFlag(Account.Access.Delete)); //Should print: "False"

            // AlertService example
            var alertService = new AlertService(new AlertDAO());
            var result = alertService.RaiseAlert();
            Console.WriteLine(result.GetType()); //Should print: "True" 

            // MergeNames example
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // Should print Ava, Emma, Olivia, Sophia

            // Song example
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");

            first.NextSong = second;
            second.NextSong = first;

            Console.WriteLine(first.IsRepeatingPlaylist());
        }
    }
}
