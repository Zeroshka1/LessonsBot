using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsBotDbProvider.ModelsDb
{
    internal class ApplicationContext : DbContext
    {
        /* КЕШИРОВАННЫЕ ДАННЫЕ */
        public DbSet<CachedGroup> CachedGroups { get; set; }
        public DbSet<CachedTeacher> CachedTeachers { get; set; }
        public DbSet<CachedCabs> CachedCabs { get; set; }

        /* СЛОВАРИК */



        /* БОТЫ */
        public List<BotProps> Bots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=local.db");
            //Database.Migrate();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //var splitStringConverter = new ValueConverter<IEnumerable<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            //builder.Entity<Entity>()
            //       .Property(nameof(Entity.SomeListOfValues))
            //       .HasConversion(splitStringConverter);
        }


    }
}
