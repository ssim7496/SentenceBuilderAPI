﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SentenceBuilderAPI.Data;

#nullable disable

namespace SentenceBuilderAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230615080651_InitialTelesure")]
    partial class InitialTelesure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SentenceBuilderAPI.Models.Sentence", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sentences");
                });

            modelBuilder.Entity("SentenceBuilderAPI.Models.Word", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WordTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Word", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "appointment",
                            WordTypeID = 1
                        },
                        new
                        {
                            ID = 2,
                            Description = "farmer",
                            WordTypeID = 1
                        },
                        new
                        {
                            ID = 3,
                            Description = "pizza",
                            WordTypeID = 1
                        },
                        new
                        {
                            ID = 4,
                            Description = "bonus",
                            WordTypeID = 1
                        },
                        new
                        {
                            ID = 5,
                            Description = "boyfriend",
                            WordTypeID = 1
                        },
                        new
                        {
                            ID = 6,
                            Description = "me",
                            WordTypeID = 2
                        },
                        new
                        {
                            ID = 7,
                            Description = "someone",
                            WordTypeID = 2
                        },
                        new
                        {
                            ID = 8,
                            Description = "whose",
                            WordTypeID = 2
                        },
                        new
                        {
                            ID = 9,
                            Description = "themselves",
                            WordTypeID = 2
                        },
                        new
                        {
                            ID = 10,
                            Description = "your",
                            WordTypeID = 2
                        },
                        new
                        {
                            ID = 11,
                            Description = "overwrought",
                            WordTypeID = 3
                        },
                        new
                        {
                            ID = 12,
                            Description = "mighty",
                            WordTypeID = 3
                        },
                        new
                        {
                            ID = 13,
                            Description = "heavenly",
                            WordTypeID = 3
                        },
                        new
                        {
                            ID = 14,
                            Description = "weary",
                            WordTypeID = 3
                        },
                        new
                        {
                            ID = 15,
                            Description = "level",
                            WordTypeID = 3
                        },
                        new
                        {
                            ID = 16,
                            Description = "permit",
                            WordTypeID = 4
                        },
                        new
                        {
                            ID = 17,
                            Description = "preserve",
                            WordTypeID = 4
                        },
                        new
                        {
                            ID = 18,
                            Description = "originate",
                            WordTypeID = 4
                        },
                        new
                        {
                            ID = 19,
                            Description = "apply",
                            WordTypeID = 4
                        },
                        new
                        {
                            ID = 20,
                            Description = "dip",
                            WordTypeID = 4
                        },
                        new
                        {
                            ID = 21,
                            Description = "hopelessly",
                            WordTypeID = 5
                        },
                        new
                        {
                            ID = 22,
                            Description = "finally",
                            WordTypeID = 5
                        },
                        new
                        {
                            ID = 23,
                            Description = "exactly",
                            WordTypeID = 5
                        },
                        new
                        {
                            ID = 24,
                            Description = "regularly",
                            WordTypeID = 5
                        },
                        new
                        {
                            ID = 25,
                            Description = "originally",
                            WordTypeID = 5
                        },
                        new
                        {
                            ID = 26,
                            Description = "without",
                            WordTypeID = 6
                        },
                        new
                        {
                            ID = 27,
                            Description = "regarding",
                            WordTypeID = 6
                        },
                        new
                        {
                            ID = 28,
                            Description = "next",
                            WordTypeID = 6
                        },
                        new
                        {
                            ID = 29,
                            Description = "under",
                            WordTypeID = 6
                        },
                        new
                        {
                            ID = 30,
                            Description = "with",
                            WordTypeID = 6
                        },
                        new
                        {
                            ID = 31,
                            Description = "if",
                            WordTypeID = 7
                        },
                        new
                        {
                            ID = 32,
                            Description = "because",
                            WordTypeID = 7
                        },
                        new
                        {
                            ID = 33,
                            Description = "while",
                            WordTypeID = 7
                        },
                        new
                        {
                            ID = 34,
                            Description = "or",
                            WordTypeID = 7
                        },
                        new
                        {
                            ID = 35,
                            Description = "and",
                            WordTypeID = 7
                        },
                        new
                        {
                            ID = 36,
                            Description = "that",
                            WordTypeID = 8
                        },
                        new
                        {
                            ID = 37,
                            Description = "this",
                            WordTypeID = 8
                        },
                        new
                        {
                            ID = 38,
                            Description = "whichever",
                            WordTypeID = 8
                        },
                        new
                        {
                            ID = 39,
                            Description = "every",
                            WordTypeID = 8
                        },
                        new
                        {
                            ID = 40,
                            Description = "all",
                            WordTypeID = 8
                        },
                        new
                        {
                            ID = 41,
                            Description = "wow!",
                            WordTypeID = 9
                        },
                        new
                        {
                            ID = 42,
                            Description = "oh joy!",
                            WordTypeID = 9
                        },
                        new
                        {
                            ID = 43,
                            Description = "I am going to faint!",
                            WordTypeID = 9
                        },
                        new
                        {
                            ID = 44,
                            Description = "no way!",
                            WordTypeID = 9
                        },
                        new
                        {
                            ID = 45,
                            Description = "for real?!",
                            WordTypeID = 9
                        });
                });

            modelBuilder.Entity("SentenceBuilderAPI.Models.WordType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("WordTypes", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Nouns"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Pronoun"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Adjectives"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Verb"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Adverbs"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Preposition"
                        },
                        new
                        {
                            ID = 7,
                            Description = "Conjuctions"
                        },
                        new
                        {
                            ID = 8,
                            Description = "Determiner"
                        },
                        new
                        {
                            ID = 9,
                            Description = "Exclamaton"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
