using System;
using Microsoft.EntityFrameworkCore;
using Survivor.Models;

namespace Survivor.Data;

public class SurvivorDbContext : DbContext
{
    public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Competitor> Competitors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(entity => entity.Competitors)
            .WithOne(entity => entity.Category)
            .HasForeignKey(entity => entity.CategoryId)
            .OnDelete(DeleteBehavior.ClientCascade); // if you delete category, delete full compititors.

        modelBuilder.Entity<Category>().HasData(
    new Category { Id = 1, Name = "Ünlüler", CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default },
    new Category { Id = 2, Name = "Gönüllüler", CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default }
);

        // Seed data for Competitors
        modelBuilder.Entity<Competitor>().HasData(
            new Competitor { Id = 1, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1 },
            new Competitor { Id = 2, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Aleyna", LastName = "Avcı", CategoryId = 1 },
            new Competitor { Id = 3, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Hadise", LastName = "Açıkgöz", CategoryId = 1 },
            new Competitor { Id = 5, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Özge", LastName = "Açık", CategoryId = 1 },
            new Competitor { Id = 4, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Sertan", LastName = "Bozkuş", CategoryId = 1 },
            new Competitor { Id = 6, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Kıvanç", LastName = "Tatlıtuğ", CategoryId = 2 },
            new Competitor { Id = 7, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2 },
            new Competitor { Id = 8, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Elif", LastName = "Demirtaş", CategoryId = 2 },
            new Competitor { Id = 9, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Cem", LastName = "Öztürk", CategoryId = 2 },
            new Competitor { Id = 10, CreatedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), ModifiedDate = DateTime.SpecifyKind(new DateTime(2024, 1, 1), DateTimeKind.Utc), IsDeleted = default, FirstName = "Ayşe", LastName = "Karaca", CategoryId = 2 }
    );
    }
}