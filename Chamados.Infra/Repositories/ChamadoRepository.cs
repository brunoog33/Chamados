using Chamados.Domain.Entities;
using Chamados.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamados.Infra.Repositories
{
    public class ChamadoRepository : RepositoryBase<Chamado>, IChamadoRepository
    {
        public IEnumerable<Chamado> BuscarPorCliente(string nome)
        {
            return Db.Chamados.Where(c => c.Cliente.RazaoSocial == nome || c.Cliente.NomeFantasia == nome);
        }
    }
}
