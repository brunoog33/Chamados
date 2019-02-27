using System.Collections.Generic;

namespace Chamados.Domain.Interfaces
{// Este repositório deve fazer o CRUD
    public interface IRepositoryBase<TEntity> where TEntity : class // Aqui é declaro que o TEntity genérico deve ser tratado como uma classe
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
