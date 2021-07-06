using System;
using static Midnight.Account;

namespace Midnight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Account example
            Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"


        }
    }
}
