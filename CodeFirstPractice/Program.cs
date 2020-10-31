using CodeFirstPractice.Models;
using System;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var db;
            using(var db = new ShelfContext())
            {
                Console.Write("Please enter Name of the shelf:");
                var name = Console.ReadLine();

                var shelf = new Shelf { Name = name };
                db.Shelfs.Add(shelf);
                db.SaveChanges();
            }
        }
    }
}
