using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace TestAVSoftClear.Models
{
    //Контекст базы данных с таблицей Counters, созданный посредством code-first(Пункт №1 ТЗ)
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Counters> Counters { get; set; }
        //Seed-Класс, заполненный предустановленными данными(Пункт №1 ТЗ)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Counters>().HasData(
                new Counters { ID = 1, KEY = 1, VALUE = 1 },
                new Counters { ID = 2, KEY = 1, VALUE = 2 },
                new Counters { ID = 3, KEY = 1, VALUE = 3 },
                new Counters { ID = 4, KEY = 2, VALUE = 1 },
                new Counters { ID = 5, KEY = 2, VALUE = 1 },
                new Counters { ID = 6, KEY = 2, VALUE = 3 },
                new Counters { ID = 7, KEY = 2, VALUE = 1 }
                );
        }
    }
}
