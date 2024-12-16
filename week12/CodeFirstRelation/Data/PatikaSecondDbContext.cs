using System;
using CodeFirstRelation.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CodeFirstRelation.Data;

public class PatikaSecondDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }

    public PatikaSecondDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) //onmodelcreating: where we determine the properties and relationships of models.
    {
        modelBuilder.Entity<Post>()
        .HasOne(entity => entity.User)
        .WithMany(entity => entity.Posts)
        .HasForeignKey(entity => entity.UserId);
    }
}
