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
    public class JeuConfig : IEntityTypeConfiguration<Jeu>
    {
        public void Configure(EntityTypeBuilder<Jeu> builder)
        {
            builder.HasKey(k => k.Titre).HasName("PK_Jeu");
            builder.Property(p => p.AnneeSortie).IsRequired();
            builder.Property(p => p.Note).IsRequired();
            builder.Property(p => p.Descriptif).IsRequired();
            builder.Property(p => p.GenreId).IsRequired();

            builder.HasOne(p => p.Genre)
               .WithMany(g => g.Jeux)
               .HasForeignKey(g => g.GenreId)
               .HasConstraintName("FK_Jeu_Genre");
        }
    }
}
