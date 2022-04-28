using GE.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Data.MyConfiguration
{
    class ContratConfiguration : IEntityTypeConfiguration<Contrat>
    {
        public void Configure(EntityTypeBuilder<Contrat> builder)
        {
            builder.HasOne(E => E.Equipe).WithMany(C => C.Contrats)
                .HasForeignKey(E => E.EquipeFK).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(M => M.Membre).WithMany(C => C.Contrats)
                .HasForeignKey(M => M.MembreFK).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
