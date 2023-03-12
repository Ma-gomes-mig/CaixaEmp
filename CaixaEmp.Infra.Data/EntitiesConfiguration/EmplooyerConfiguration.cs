using CaixaEmp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.Data.EntitiesConfiguration
{
    public class EmplooyerConfiguration : IEntityTypeConfiguration<Emplooyer>
    {
        public void Configure(EntityTypeBuilder<Emplooyer> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Office).HasMaxLength(50).IsRequired();

            builder.HasMany(e => e.Expenses).WithOne(e => e.Emplooyer).HasForeignKey(f => f.EmplooyerId);
            builder.HasMany(e => e.Withdrawals).WithOne(e => e.Emplooyer).HasForeignKey(f => f.EmplooyerId);
            builder.HasMany(e => e.Inclusions).WithOne(e => e.Emplooyer).HasForeignKey(f => f.EmplooyerId);
        }
    }
}
