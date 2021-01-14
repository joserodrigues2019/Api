using Api.Database.Models;
using Api.Database.Repositories;
using System.Collections.Generic;

namespace Api.BussinesLogic
{
    public class ContasPagarBll : IContasPagarBll
    {
        private readonly IContasPagarRepository _contasPagarRepository;

        public ContasPagarBll(IContasPagarRepository contasPagarRepository)
        {
            _contasPagarRepository = contasPagarRepository;
        }

        public IEnumerable<ContasPagarEntity> Listar()
        {
            return  _contasPagarRepository.Listar();
        }
    }
}
