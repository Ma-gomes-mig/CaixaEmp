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
    public class MonthConfiguration : IEntityTypeConfiguration<Month>
    {
        public void Configure(EntityTypeBuilder<Month> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Name).HasMaxLength(20).IsRequired();

            builder.HasData(
                new Month(1, "Janeiro"),
                new Month(2, "Fevereiro"),
                new Month(3, "Março"),
                new Month(4, "Abril"),
                new Month(5, "Maio"),
                new Month(6, "Junho"),
                new Month(7, "Julho"),
                new Month(8, "Agosto"),
                new Month(9, "Setembro"),
                new Month(10, "Outubro"),
                new Month(11, "Novembro"),
                new Month(12, "Dezembro"));
        }
    }
}
