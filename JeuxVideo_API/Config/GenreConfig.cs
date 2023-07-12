using JeuxVideo_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVideo_API.Config
{
    internal class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(k => k.Id).HasName("PK_Genre");
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nom).IsRequired();

            builder.HasMany(p => p.Jeux)
               .WithOne(g => g.Genre)
               .HasForeignKey(g => g.GenreId)
               .HasConstraintName("FK_Genre_Jeu");
        }
    }
}
