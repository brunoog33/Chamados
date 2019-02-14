using Chamados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamados.Infra.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.RazaoSocial)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.NomeFantasia)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
