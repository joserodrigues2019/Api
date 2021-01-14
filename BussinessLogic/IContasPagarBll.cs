using Api.Database.Models;
using System.Collections.Generic;

namespace Api.BussinessLogic
{
    public interface IContasPagarBll
    {
        IEnumerable<ContasPagarEntity> Listar();
        string Incluir(ContasPagarEntity contasPagar);
    }
}
