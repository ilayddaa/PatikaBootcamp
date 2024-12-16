using System;
using CodeFirstBasic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data;

public class PatikaFirstDbContext : DbContext
{
    public PatikaFirstDbContext(DbContextOptions options) : base(options) //use options on DbContext
    {

    }

    public DbSet<Game> Games { get; set; } // create table on DataBase
    public DbSet<Movie> Movies { get; set; }

}
