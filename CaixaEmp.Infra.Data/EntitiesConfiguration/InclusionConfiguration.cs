﻿using CaixaEmp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEmp.Infra.Data.EntitiesConfiguration
{
    public class InclusionConfiguration : IEntityTypeConfiguration<Inclusion>
    {
        public void Configure(EntityTypeBuilder<Inclusion> builder)
        {
            builder.HasKey(k => k.Id);
            //builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(150);
            builder.Property(p => p.Value).HasPrecision(10, 2).IsRequired();    
            builder.Property(p =>p.DateInclusion).IsRequired();
            builder.Property(p => p.Priority).HasMaxLength(30);
            builder.Property(p => p.Status).HasMaxLength(30);

            builder.HasOne(e => e.Emplooyer).WithMany(e => e.Inclusions).HasForeignKey(f => f.EmplooyerId);
            builder.HasOne(e => e.Expense).WithMany(e => e.Inclusions).HasForeignKey(f => f.ExpenseId);
            builder.HasOne(e => e.Balance).WithMany(e => e.Inclusions).HasForeignKey(f => f.BalanceId);
            builder.HasOne(e => e.Month).WithMany(e => e.Inclusions).HasForeignKey(f => f.MonthId);
        }
    }
}
