
using Chamados.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Chamados.Infra.EntityConfig
{
    public class ChamadoConfiguration : EntityTypeConfiguration<Chamado>
    {

        public ChamadoConfiguration()
        {
            HasKey(x => x.ChamadoID);

            Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(250);

            Property(x => x.DataCadastro)
                .IsRequired();

            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(x => x.ClienteId);
        }

    }
}
