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


            //builder.HasData(new Emplooyer(1, "Dulce", "Administrativo"),
            //    new Emplooyer(2, "Camila", "Administrativo"),
            //    new Emplooyer(3, "Ane", "Estoque"),
            //    new Emplooyer(4, "Leo", "Estoque"),
            //    new Emplooyer(5, "Lucas", "TI"),
            //    new Emplooyer(6, "Matheus", "TI"));
        }
    }
}
