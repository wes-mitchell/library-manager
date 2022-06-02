## Initial Prompts for Exercise

1. Create a console application (call it Library)
2. Unlike in the past, when we've erased the Program class and Main methods, leave them there this time.
3. Create a new file called Book.cs . In that file, create a class called Book . Put it in the same namespace as the Program class.
4. The Book class should have Title, Author, PublishDate, and Genre properties.
5. In the main method, create an instance of the Book class, and save its value as a variable
6. Using your instance of Book, print out its Title and Author to the Console in the format   Title, by Author
7. Create some more books and store them in a List
8. Iterate over that list of books, and print the title and author to the Console in the loop in the same format as in 6.
9. Create another file called LibraryManager.cs and create another class in it called LibraryManager. Put the class in the same namespace as the other classes
10. Add a constructor method to your LibraryManager class that takes a string parameter that will represent the library's name.
11. Create a Name property in the LibraryManager class and use the the constructor to set the name parameter in the constructor as the value of Name when a new instance is created.
12. Create a private field in the LibraryManager class called _books. Its type will be List-Book , and you can set it equal to an empty List-Book
13. Write a method for the LibraryManager class that displays the books in an instance of LibraryManagerusing the same format as #6 and #8
14. Write a method to add a book to an instance of LibraryManager's _books field, it should take a parameter of type Book
15. Remove the code in the main method that you added in steps 6 and 8
16. Create a new instance of the LibraryManager class at the beginning of the Main method, pass the constructor a name for your library.
17. Write out "Welcome to the Name Library Management System!" to the console using your library instance.
18. Use the method your wrote to add books to add all of the books you created in steps 5 and 7 to your instance of LibraryManagers _books
19. Use the method you wrote to list all of the books to print all of the books out to the console.