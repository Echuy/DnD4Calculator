using DnD4Calculator.Models.Creatures.Beasts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD4Calculator.Models
{
    public class DataContext : DbContext
    {
        public DbSet<DnDObject> DnDObjects { get; set; }
        public DbSet<Monster> monsters { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
