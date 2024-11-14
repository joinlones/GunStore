// Data/ApplicationDbContext.cs
using GunStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GunStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gun> Guns { get; set; }
    }
}