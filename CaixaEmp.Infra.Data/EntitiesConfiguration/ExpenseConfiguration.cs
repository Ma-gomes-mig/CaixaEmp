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
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Value).HasPrecision(10, 2).IsRequired();
            builder.Property(p => p.Priority).HasMaxLength(30).IsRequired();

            builder.HasOne(e => e.Emplooyer).WithMany(e => e.Expenses).HasForeignKey(f => f.EmplooyerId);
            builder.HasOne(e => e.ExpenseCategory).WithMany(e => e.Expenses).HasForeignKey(f => f.ExpenseCategoryId);

            //builder.HasData(
            //    new Expense(1, "Compra Agua", "Dinheiro destinado a compra do galão de agua", 30, "Média",1,1),
            //    new Expense());
        }
    }
}
