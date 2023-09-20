﻿// <auto-generated />
using System;
using LibraryApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryApp.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("authors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Джуан Роулинг"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Агата Кристи"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Толстой А.Н."
                        },
                        new
                        {
                            Id = 4,
                            Name = "Пётр Ершов"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Роберт Мартин"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Васильев А."
                        },
                        new
                        {
                            Id = 8,
                            Name = "Геворкян П.С."
                        },
                        new
                        {
                            Id = 9,
                            Name = "Аллен Дауни"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Заур Трегулов"
                        });
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GivenDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 20, 16, 54, 46, 246, DateTimeKind.Local).AddTicks(6419))
                        .HasColumnName("given_date");

                    b.Property<bool>("IsExpired")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("is_expired");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<int>("PartitionId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1)
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PartitionId");

                    b.HasIndex("UserId");

                    b.ToTable("books", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Гарри Поттер и философский камень",
                            PartitionId = 1,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Гарри Поттер и тайная комната",
                            PartitionId = 1,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Гарри Поттер и принц полукровка",
                            PartitionId = 1,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Гарри Поттер и орден феникса",
                            PartitionId = 1,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 1,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Гарри Поттер и дары смерти",
                            PartitionId = 1,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 2,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Убийство в восточном экспрессе",
                            PartitionId = 2,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Убийство на Ниле",
                            PartitionId = 2,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 2,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Призрак Венеции",
                            PartitionId = 2,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 3,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Колобок",
                            PartitionId = 3,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 4,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Конек горбунок",
                            PartitionId = 3,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 3,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Гуси-Лебеди",
                            PartitionId = 3,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 6,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Чистая архитектура",
                            PartitionId = 4,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 7,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Самоучитель по c#",
                            PartitionId = 4,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 8,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Высшая матиматика",
                            PartitionId = 4,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 9,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "Основы Python",
                            PartitionId = 4,
                            Status = 0,
                            UserId = 0
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 10,
                            GivenDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsExpired = false,
                            Name = "SQL для начинающих с нуля до сертификата Oracle",
                            PartitionId = 4,
                            Status = 0,
                            UserId = 0
                        });
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.Partition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("partitions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Фантастика"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Детективы"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Детские"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Учебный материал"
                        });
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsManager")
                        .HasColumnType("bit")
                        .HasColumnName("is_manager");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsManager = false,
                            Name = "Администратор",
                            Password = "Admin",
                            Role = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            IsManager = false,
                            Name = "Менеджер",
                            Password = "Manager",
                            Role = "Manager"
                        },
                        new
                        {
                            Id = 3,
                            IsManager = false,
                            Name = "Читатель",
                            Password = "Reader",
                            Role = "User"
                        },
                        new
                        {
                            Id = 4,
                            IsManager = false,
                            Name = "Администратор2",
                            Password = "Admin",
                            Role = "Administrator"
                        },
                        new
                        {
                            Id = 5,
                            IsManager = false,
                            Name = "Менеджер2",
                            Password = "Manager",
                            Role = "Manager"
                        },
                        new
                        {
                            Id = 6,
                            IsManager = false,
                            Name = "Читатель2",
                            Password = "Reader",
                            Role = "User"
                        });
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.Book", b =>
                {
                    b.HasOne("LibraryApp.DataAccess.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryApp.DataAccess.Entities.Partition", "Partition")
                        .WithMany("Books")
                        .HasForeignKey("PartitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryApp.DataAccess.Entities.User", "User")
                        .WithMany("GivenBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Partition");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.Partition", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryApp.DataAccess.Entities.User", b =>
                {
                    b.Navigation("GivenBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
