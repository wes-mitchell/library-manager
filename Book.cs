using System;

namespace Library
{
  public class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublishDate = new DateTime();
    public string Genre { get; set; }

    public Book(string title, string author, DateTime date, string genre)
    {
      Title = title;
      Author = author;
      PublishDate = date;
      Genre = genre;

    }

  }
}