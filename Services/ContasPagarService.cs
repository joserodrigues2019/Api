using Api.Domain.Models;
using Api.Domain.Repositories;
using Api.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public class ContasPagarService : IContasPagarService
    {
        private readonly IContasPagarRepository _contasPagarRepository;

        public ContasPagarService(IContasPagarRepository contasPagarRepository)
        {
            _contasPagarRepository = contasPagarRepository;
        }

        public async Task<IEnumerable<ContasPagarEntity>> ListAsync()
        {
            return await _contasPagarRepository.ListAsync();
        }

        public async void Incluir(ContasPagarEntity contasPagar)
        {
            await _contasPagarRepository.Add(contasPagar);
        }
    }
}
