using Microsoft.EntityFrameworkCore;
using SentenceBuilderAPI.Data.Configuration;
using SentenceBuilderAPI.Models;
using System.Reflection.Metadata;

namespace SentenceBuilderAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<WordType> WordTypes => Set<WordType>();
        public DbSet<Sentence> Sentences => Set<Sentence>();
        public DbSet<Word> Words => Set<Word>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WordTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WordConfiguration());
        }
    }
}
