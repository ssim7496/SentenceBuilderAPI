using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SentenceBuilderAPI.Models;

namespace SentenceBuilderAPI.Data.Configuration
{
    public class WordTypeConfiguration : IEntityTypeConfiguration<WordType>
    {
        public void Configure(EntityTypeBuilder<WordType> builder)
        {
            builder.ToTable("WordTypes");
            builder.Property(wt => wt.Description)
                .IsRequired(true);
            builder.HasData
            (
                new WordType { ID = 1, Description = "Nouns" },
                new WordType { ID = 2, Description = "Pronoun" },
                new WordType { ID = 3, Description = "Adjectives" },
                new WordType { ID = 4, Description = "Verb" },
                new WordType { ID = 5, Description = "Adverbs" },
                new WordType { ID = 6, Description = "Preposition" },
                new WordType { ID = 7, Description = "Conjuctions" },
                new WordType { ID = 8, Description = "Determiner" },
                new WordType { ID = 9, Description = "Exclamaton" }
            );
        }
    }
}
