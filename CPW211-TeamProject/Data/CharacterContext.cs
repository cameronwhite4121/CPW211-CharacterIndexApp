using CPW211_TeamProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_TeamProject.Data;

public class CharacterContext : DbContext
{
    public CharacterContext()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // Database connection string
        options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CharacterIndex;Trusted_Connection=True;");
    }

    // Tracks characters in the database
    public DbSet<Character> Characters { get; set; }
}

