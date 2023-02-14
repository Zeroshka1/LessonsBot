﻿using Microsoft.EntityFrameworkCore;

namespace LessonsBotDbProvider.ModelsDb
{
    public class ApplicationContext : DbContext
    {
        /* КЕШИРОВАННЫЕ ДАННЫЕ */
        public DbSet<CachedGroup> CachedGroups { get; set; }
        public DbSet<CachedTeacher> CachedTeachers { get; set; }
        public DbSet<CachedCabs> CachedCabs { get; set; }

        /* СЛОВАРИК */
        public DbSet<WordBook> WordBooks { get; set; }

        /* БОТЫ */
        public DbSet<Bot> Bots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.db");
            //Database.Migrate();
            base.OnConfiguring(optionsBuilder);
        }


        public ApplicationContext()
            => Database.Migrate();
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //var splitStringConverter = new ValueConverter<IEnumerable<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            //builder.Entity<Entity>()
            //       .Property(nameof(Entity.SomeListOfValues))
            //       .HasConversion(splitStringConverter);
        }

    }
}
