﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Videogame_DB.Infra.Context;

#nullable disable

namespace Videogame_DB.Infra.Data.Migrations
{
    [DbContext(typeof(PersonalGamesContext))]
    partial class PersonalGamesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Videogame_DB.Domain.Entities.PersonalGames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EndPlay")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("EndPlay");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("GameName");

                    b.Property<string>("Score")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Score");

                    b.Property<string>("StartPlay")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("StartPlay");

                    b.HasKey("Id");

                    b.ToTable("PersonalGames", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}