using JeuxVideo_API.Config;
using JeuxVideo_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVideo_API
{
    internal class ExempleContext : DbContext
    {
        public DbSet<Jeu> Jeux { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Jeu>(new JeuConfig());
            modelBuilder.ApplyConfiguration<Genre>(new GenreConfig());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=FIXE-EMILIE\MSSQLSERVER01;Initial Catalog=JeuxVideoEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}