using System;
using System.Data.Common;
using homework2.Models;
using Microsoft.EntityFrameworkCore;

namespace homework2.Data;

public class JwtDbContext : DbContext
{
    public JwtDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
}
