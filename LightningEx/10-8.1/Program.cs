using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book lordOfTheRings = new Book() {
                Title = "Lord of the Rings",
                Author = "JRR Tolkien",
                ISBN = "LOTR1"
            };

            Book theTwoTowers = new Book();
                theTwoTowers.Title = "The Two Towers";
                theTwoTowers.Author = "JRR Tolkien";
                theTwoTowers.ISBN = "LOTR2";
            

            Book returnOfTheKing = new Book() {
                Title = "Return of the King",
                Author = "JRR Tolkien",
                ISBN = "LOTR3"
            };

            Book theSorcerersStone = new Book() {
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "Whats HerName",
                ISBN = "HP1"
            };

            Book theChamberOfSecrets = new Book() {
                Title = "Harry Potter and the Chamber of Secrets",
                Author = "Whats HerName",
                ISBN = "HP2"
            };

            Book book2 = new Book() {
                Title = "book2",
                Author = "Whats HerName",
                ISBN = "2B"
            };

            List<Book> books = new List<Book>() {
                theChamberOfSecrets
            };

            Library library = new Library(books, "NSS Library", "123 SomeWhere");

            library.AddToInventory(lordOfTheRings);
            library.AddToInventory(theTwoTowers);
            library.AddToInventory(returnOfTheKing);
            library.AddToInventory(theSorcerersStone);

            if (library.IsAvailable("HP1")) {
                Console.WriteLine("is available");
            } else {
                Console.WriteLine("is unavailable");
            }
        }
    }
}
