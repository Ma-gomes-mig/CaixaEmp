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
    public class BalanceConfiguration : IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Value).HasPrecision(10, 2).IsRequired();
            builder.Property(p => p.Date);

            
        }
    }
}
