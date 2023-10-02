using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videogame_DB.Domain.Entities;
using Videogame_DB.Infra.Mapping;

namespace Videogame_DB.Infra.Context
{
    public class PersonalGamesContext : DbContext
    {
        public PersonalGamesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PersonalGames> PersonalGamesDbSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PersonalGames>(new PersonalGamesMap().Configure);
        }
    }
}
