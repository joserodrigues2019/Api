using Api.Domain.Models;
using Api.Domain.Repositories;
using Api.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Persistence.Repositories
{
    public class ContasPagarRepository: BaseRepository, IContasPagarRepository
    {
        public ContasPagarRepository(AppDbContext context) : base(context)
        {

        }
        public async Task Add(ContasPagarEntity clientes)
        {
            await _context.ContasPagar.AddAsync(clientes);

            _context.SaveChanges();
        }

        public async Task<IEnumerable<ContasPagarEntity>> ListAsync()
        {
            return await _context.ContasPagar.ToListAsync();
        }
    }
}
