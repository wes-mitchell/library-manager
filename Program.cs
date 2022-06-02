using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book theShining = new Book("The Shining", "Stephen King", new DateTime(1977, 01, 28), "thriller");
            Book kitchenConfidential = new Book("Kitchen Confidential", "Anthony Bourdain", new DateTime(2000, 05, 22), "autobiography");
            Book moneyBall = new Book("Moneyball", "Michael Lewis", new DateTime(2003, 06, 17), "non-fiction");
            Book it = new Book("It", "Stephen King", new DateTime(1986, 09, 15), "thriller");

            // List<Book> bookList = new List<Book>();
            // bookList.Add(theShining);
            // bookList.Add(kitchenConfidential);
            // bookList.Add(moneyBall);

            LibraryManager npl = new LibraryManager("Nashville Public Library");

            npl.AddBook(theShining);
            npl.AddBook(it);
            npl.AddBook(kitchenConfidential);
            npl.AddBook(moneyBall);

            Console.WriteLine($"Welcome to the {npl.Name} Management System!");
            Console.WriteLine("---------------------------------------------");

            npl.ShowBooks();
        
        }

    }
}

// Write a method for the LibraryManager class that displays the books in an instance of LibraryManager using the same format as #6 and #8
// Write a method to add a book to an instance of LibraryManager's _books field, it should take a parameter of type Book
// Remove the code in the main method that you added in steps 6 and 8
// Create a new instance of the LibraryManager class at the beginning of the Main method, pass the constructor a name for your library.
// Write out "Welcome to the <Name> Library Management System!" to the console using your library instance.
// Use the method your wrote to add books to add all of the books you created in steps 5 and 7 to your instance of LibraryManagers _books
// Use the method you wrote to list all of the books to print all of the books out to the console.


