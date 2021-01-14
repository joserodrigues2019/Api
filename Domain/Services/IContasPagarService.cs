using Api.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Services
{
    public interface IContasPagarService
    {
        Task<IEnumerable<ContasPagarEntity>> ListAsync();
        void Incluir(ContasPagarEntity contasPagar);
    }
}
