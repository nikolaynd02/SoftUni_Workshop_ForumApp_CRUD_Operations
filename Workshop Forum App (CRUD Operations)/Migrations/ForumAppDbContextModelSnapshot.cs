﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workshop_Forum_App__CRUD_Operations_.Data;

#nullable disable

namespace Workshop_Forum_App__CRUD_Operations_.Migrations
{
    [DbContext(typeof(ForumAppDbContext))]
    partial class ForumAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Workshop_Forum_App__CRUD_Operations_.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Posts Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasComment("Content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Post title");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasComment("Published posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "My first post will be about performing CRUD operations in MVC. It's so much fun!",
                            Title = "My First Post"
                        },
                        new
                        {
                            Id = 2,
                            Content = "My second post will be about performing CRUD operations in MVC. It's so much fun!",
                            Title = "My Second Post"
                        },
                        new
                        {
                            Id = 3,
                            Content = "My third post will be about performing CRUD operations in MVC. It's so much fun!",
                            Title = "My Third Post"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
