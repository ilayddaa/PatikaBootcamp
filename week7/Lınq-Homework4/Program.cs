using Lınq_Homework4;

List<Author> authors = new List<Author>
{
    new Author("Orhan Pamuk", 1),
    new Author("Elif Şafak", 2),
    new Author("Ahmet Ümit", 3)
};

List<Book> books = new List<Book>
{
new Book("Kar",1,1),
new Book("İstanbul",2,1),
new Book("10 Minutes 38 Seconds in This Strange World",3,2),
new Book ("Beyoğlu Rapsodisi",4,3),
};

var authorBooks = authors.Join(books, 
author =>author.Id,
book => book.AuthorId,
(author, book) => new
{
    AuthorName = author.Name,
    BookTitle = book.Title
});
Console.Clear();
foreach (var author in authorBooks)
{
    Console.WriteLine($"{author.AuthorName} adlı yazara ait {author.BookTitle} adlı kitabı bulunmaktadır.");
}



Console.ReadKey();