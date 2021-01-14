using Api.Database.Models;
using System.Collections.Generic;

namespace Api.BussinesLogic
{
    public interface IContasPagarBll
    {
        IEnumerable<ContasPagarEntity> Listar();
    }
}
