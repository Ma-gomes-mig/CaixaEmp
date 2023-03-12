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
    public class ExpenseCategoryConfiguration : IEntityTypeConfiguration<ExpenseCategory>
    {
        public void Configure(EntityTypeBuilder<ExpenseCategory> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).HasMaxLength(30).IsRequired();
            builder.Property(p=>p.Description).HasMaxLength(150).IsRequired();

            
        }
    }
}
