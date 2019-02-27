using Chamados.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chamados.Domain.Interfaces.Services
{
    public interface IChamadoService : IServiceBase<Chamado>
    {
        IEnumerable<Chamado> BuscarPorCliente(string nome);
    }
}
