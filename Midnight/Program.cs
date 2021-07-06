using System;
using static Midnight.Account;

namespace Midnight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Account
            //Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
            Console.WriteLine(Access.Writer.HasFlag(Access.Delete));
        }
    }
}
