using Api.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Repositories
{
    public interface IContasPagarRepository
    {
        Task<IEnumerable<ContasPagarEntity>> ListAsync();
        Task Add(ContasPagarEntity clientes);
    }
}
