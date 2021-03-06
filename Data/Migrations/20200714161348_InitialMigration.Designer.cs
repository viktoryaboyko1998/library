// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20200714161348_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Oscar Wilde",
                            Title = "The Picture of Dorian Gray",
                            Year = 1890
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jack London",
                            Title = "White fang",
                            Year = 1906
                        },
                        new
                        {
                            Id = 3,
                            Author = "Daniel Defo",
                            Title = "Robinson Crusoe",
                            Year = 1719
                        },
                        new
                        {
                            Id = 4,
                            Author = "Ernest Hemingway",
                            Title = "The Old Man and the Sea",
                            Year = 1952
                        },
                        new
                        {
                            Id = 5,
                            Author = "George R. R. Martin",
                            Title = "A Dance with Dragons",
                            Year = 2011
                        });
                });

            modelBuilder.Entity("Data.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReaderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReaderId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2016, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderId = 2
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderId = 3
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2016, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderId = 4
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderId = 4
                        });
                });

            modelBuilder.Entity("Data.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TakeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CardId");

                    b.ToTable("Histories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CardId = 1,
                            ReturnDate = new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakeDate = new DateTime(2016, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CardId = 4,
                            ReturnDate = new DateTime(2016, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakeDate = new DateTime(2016, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            CardId = 4,
                            ReturnDate = new DateTime(2016, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakeDate = new DateTime(2016, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            BookId = 2,
                            CardId = 1,
                            ReturnDate = new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakeDate = new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            BookId = 1,
                            CardId = 2,
                            ReturnDate = new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakeDate = new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            BookId = 3,
                            CardId = 1,
                            TakeDate = new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            BookId = 4,
                            CardId = 3,
                            TakeDate = new DateTime(2020, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            BookId = 5,
                            CardId = 5,
                            TakeDate = new DateTime(2020, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Data.Entities.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Readers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "serhii_email@gmail.com",
                            Name = "Serhii"
                        },
                        new
                        {
                            Id = 2,
                            Email = "ivan_email@gmail.com",
                            Name = "Ivan"
                        },
                        new
                        {
                            Id = 3,
                            Email = "petro_email@gmail.com",
                            Name = "Petro"
                        },
                        new
                        {
                            Id = 4,
                            Email = "oleksandr_email@gmail.com",
                            Name = "Oleksandr"
                        });
                });

            modelBuilder.Entity("Data.Entities.ReaderProfile", b =>
                {
                    b.Property<int>("ReaderId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReaderId");

                    b.ToTable("ReaderProfiles");

                    b.HasData(
                        new
                        {
                            ReaderId = 1,
                            Address = "Kyiv, 1",
                            Phone = "123456789"
                        },
                        new
                        {
                            ReaderId = 2,
                            Address = "Kyiv, 2",
                            Phone = "456789123"
                        },
                        new
                        {
                            ReaderId = 3,
                            Address = "Kyiv, 3",
                            Phone = "789123456"
                        },
                        new
                        {
                            ReaderId = 4,
                            Address = "Kyiv, 4",
                            Phone = "326159487"
                        });
                });

            modelBuilder.Entity("Data.Entities.Card", b =>
                {
                    b.HasOne("Data.Entities.Reader", "Reader")
                        .WithMany("Card")
                        .HasForeignKey("ReaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.History", b =>
                {
                    b.HasOne("Data.Entities.Book", "Book")
                        .WithMany("Cards")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Card", "Card")
                        .WithMany("Books")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.ReaderProfile", b =>
                {
                    b.HasOne("Data.Entities.Reader", "Reader")
                        .WithOne("ReaderProfile")
                        .HasForeignKey("Data.Entities.ReaderProfile", "ReaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
