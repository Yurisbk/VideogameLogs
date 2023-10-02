using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videogame_DB.Domain.Entities;

namespace Videogame_DB.Infra.Mapping
{
    public class PersonalGamesMap : IEntityTypeConfiguration<PersonalGames>
    {
        public void Configure(EntityTypeBuilder<PersonalGames> builder)
        {
            builder.ToTable("PersonalGames");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.GameName)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("GameName")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.StartPlay)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("StartPlay")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.EndPlay)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("EndPlay")
                .HasColumnType("varchar(100)");


            builder.Property(prop => prop.Score)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Score")
                .HasColumnType("varchar(100)");
        }
    }
}
