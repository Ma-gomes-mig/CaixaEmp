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
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p=>p.Description).HasMaxLength(250).IsRequired();

            builder.HasMany(e => e.Expenses).WithOne(e => e.ExpenseCategory).HasForeignKey(f => f.ExpenseCategoryId);

            builder.HasData(
                new ExpenseCategory(1, "Insumos Higiene", "Todo material que seja para uso da higiene da area de trabalho como: " +
                "Esponja, detergente, papel higiênico, etc..."),
                new ExpenseCategory(2, "Insumos Papelaria", "Todo material que seja para uso do escritório como:" +
                "Fita adesiva, lápis, grampos, papel para impressão, etc..."),
                new ExpenseCategory(3, "Insumos Alimentares", "Todo material que seja para uso dos colaboradores como: " +
                "Biscoito, agua, etc"),
                new ExpenseCategory(4, "Insumos Saude", "Todo material que seja para uso dos colaboradores como: " +
                "Remedio, band-aid"));
        }
    }
}
