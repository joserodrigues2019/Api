using Api.Domain.Models;
using Api.Domain.Repositories;
using Api.Domain.Services;
using System.Collections.Generic;

namespace Api.Services
{
    public class ContasPagarService : IContasPagarService
    {
        private readonly IContasPagarRepository _contasPagarRepository;

        public ContasPagarService(IContasPagarRepository contasPagarRepository)
        {
            _contasPagarRepository = contasPagarRepository;
        }

        public IEnumerable<ContasPagarEntity> Listar()
        {
            return  _contasPagarRepository.Listar();
        }
    }
}
