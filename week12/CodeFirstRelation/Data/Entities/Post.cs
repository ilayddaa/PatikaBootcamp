using System;

namespace CodeFirstRelation.Data.Entities;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } // every post has one user.
}
