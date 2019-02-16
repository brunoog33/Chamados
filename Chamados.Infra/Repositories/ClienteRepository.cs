using Chamados.Domain.Entities;
using Chamados.Domain.Interfaces;

namespace Chamados.Infra.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
