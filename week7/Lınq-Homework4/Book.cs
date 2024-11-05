using System;

namespace Lınq_Homework4;

public class Book
{
    public string Title { get; set; }
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    public Book(string Title, int BookId, int AuthorId)
    {
        this.Title = Title;
        this.BookId = BookId;
        this.AuthorId = AuthorId;
    }
}
