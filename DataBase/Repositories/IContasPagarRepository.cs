using Api.Database.Models;
using System.Collections.Generic;

namespace Api.Database.Repositories
{
    public interface IContasPagarRepository
    {
        IEnumerable<ContasPagarEntity> Listar();
    }
}
