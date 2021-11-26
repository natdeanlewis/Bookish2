using System;
using Bookish2.DataAccess;

namespace Bookish2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LibraryDatabaseClient.GetAllBooks();
            Console.WriteLine();
            LibraryDatabaseClient.GetAllLoans(1);
            Console.WriteLine();
            LibraryDatabaseClient.Search("am");
            Console.WriteLine();
            LibraryDatabaseClient.CheckAvailability(4);
        }
    }
}