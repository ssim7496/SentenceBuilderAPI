using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SentenceBuilderAPI.Models;

namespace SentenceBuilderAPI.Data.Configuration
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.ToTable("Word");
            builder.Property(wt => wt.ID)
                .ValueGeneratedOnAdd();
            builder.Property(wt => wt.Description)
                .IsRequired(true);
            builder.Property(wt => wt.WordTypeID)
                .IsRequired(true);
            builder.HasData
            (
                new Word { ID = 1, Description = "appointment", WordTypeID = 1 },
                new Word { ID = 2, Description = "farmer", WordTypeID = 1 },
                new Word { ID = 3, Description = "pizza", WordTypeID = 1 },
                new Word { ID = 4, Description = "bonus", WordTypeID = 1 },
                new Word { ID = 5, Description = "boyfriend", WordTypeID = 1 },

                new Word { ID = 6, Description = "me", WordTypeID = 2 },
                new Word { ID = 7, Description = "someone", WordTypeID = 2 },
                new Word { ID = 8, Description = "whose", WordTypeID = 2 },
                new Word { ID = 9, Description = "themselves", WordTypeID = 2 },
                new Word { ID = 10, Description = "your", WordTypeID = 2 },

                new Word { ID = 11, Description = "overwrought", WordTypeID = 3 },
                new Word { ID = 12, Description = "mighty", WordTypeID = 3 },
                new Word { ID = 13, Description = "heavenly", WordTypeID = 3 },
                new Word { ID = 14, Description = "weary", WordTypeID = 3 },
                new Word { ID = 15, Description = "level", WordTypeID = 3 }, 

                new Word { ID = 16, Description = "permit", WordTypeID = 4 },
                new Word { ID = 17, Description = "preserve", WordTypeID = 4 },
                new Word { ID = 18, Description = "originate", WordTypeID = 4 },
                new Word { ID = 19, Description = "apply", WordTypeID = 4 },
                new Word { ID = 20, Description = "dip", WordTypeID = 4 },

                new Word { ID = 21, Description = "hopelessly", WordTypeID = 5 },
                new Word { ID = 22, Description = "finally", WordTypeID = 5 },
                new Word { ID = 23, Description = "exactly", WordTypeID = 5 },
                new Word { ID = 24, Description = "regularly", WordTypeID = 5 },
                new Word { ID = 25, Description = "originally", WordTypeID = 5 },
            
                new Word { ID = 26, Description = "without", WordTypeID = 6 },
                new Word { ID = 27, Description = "regarding", WordTypeID = 6 },
                new Word { ID = 28, Description = "next", WordTypeID = 6 },
                new Word { ID = 29, Description = "under", WordTypeID = 6 },
                new Word { ID = 30, Description = "with", WordTypeID = 6 },

                new Word { ID = 31, Description = "if", WordTypeID = 7 },
                new Word { ID = 32, Description = "because", WordTypeID = 7 },
                new Word { ID = 33, Description = "while", WordTypeID = 7 },
                new Word { ID = 34, Description = "or", WordTypeID = 7 },
                new Word { ID = 35, Description = "and", WordTypeID = 7 },

                new Word { ID = 36, Description = "that", WordTypeID = 8 },
                new Word { ID = 37, Description = "this", WordTypeID = 8 },
                new Word { ID = 38, Description = "whichever", WordTypeID = 8 },
                new Word { ID = 39, Description = "every", WordTypeID = 8 },
                new Word { ID = 40, Description = "all", WordTypeID = 8 },

                new Word { ID = 41, Description = "wow!", WordTypeID = 9 },
                new Word { ID = 42, Description = "oh joy!", WordTypeID = 9 },
                new Word { ID = 43, Description = "I am going to faint!", WordTypeID = 9 },
                new Word { ID = 44, Description = "no way!", WordTypeID = 9 },
                new Word { ID = 45, Description = "for real?!", WordTypeID = 9 }
            );
        }
    }
}
