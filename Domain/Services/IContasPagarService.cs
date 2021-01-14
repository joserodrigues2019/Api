using Api.Domain.Models;
using System.Collections.Generic;

namespace Api.Domain.Services
{
    public interface IContasPagarService
    {
        IEnumerable<ContasPagarEntity> Listar();
    }
}
