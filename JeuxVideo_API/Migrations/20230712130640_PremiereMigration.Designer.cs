﻿// <auto-generated />
using JeuxVideo_API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JeuxVideo_API.Migrations
{
    [DbContext(typeof(ExempleContext))]
    [Migration("20230712130640_PremiereMigration")]
    partial class PremiereMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JeuxVideo_API.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Genre");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("JeuxVideo_API.Models.Jeu", b =>
                {
                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AnneeSortie")
                        .HasColumnType("int");

                    b.Property<string>("Descriptif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.HasKey("Titre")
                        .HasName("PK_Jeu");

                    b.HasIndex("GenreId");

                    b.ToTable("Jeux");
                });

            modelBuilder.Entity("JeuxVideo_API.Models.Jeu", b =>
                {
                    b.HasOne("JeuxVideo_API.Models.Genre", "Genre")
                        .WithMany("Jeux")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Genre_Jeu");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("JeuxVideo_API.Models.Genre", b =>
                {
                    b.Navigation("Jeux");
                });
#pragma warning restore 612, 618
        }
    }
}
