using Chamados.Domain.Entities;
using Chamados.Infra.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Chamados.Infra.Contexto
{
    public class ProjetoChamadoContext : DbContext
    {
        public ProjetoChamadoContext() : base("Chamados")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // Desabilita convenções do banco de dados
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties() // Toda coluna que possuir Id será chave da minha tabela
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>() // Toda coluna que possuir for string será um varchar, pois como padrão pega nvarchar
               .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>() // Toda coluna que possuir for string terá um tamanho específico, pois sempre pega max
               .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                /*if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataModificacao").CurrentValue = DateTime.Now;
                }*/
            }

            return base.SaveChanges();
        }


    }
}
