using Api.Domain.Models;
using Api.Domain.Repositories;
using Api.Persistence.Contexts;
using System.Collections.Generic;

namespace Api.Persistence.Repositories
{
    public class ContasPagarRepository: BaseRepository, IContasPagarRepository
    {
        public ContasPagarRepository(AppDbContext context) : base(context)
        {

        }

        public IEnumerable<ContasPagarEntity> Listar()
        {
            return _context.ContasPagar;
        }
    }
}
