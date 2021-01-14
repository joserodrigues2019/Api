using Api.Domain.Models;
using Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContasPagarController : ControllerBase
    {
        private readonly IContasPagarService _serviceContasPagar;

        public ContasPagarController(IContasPagarService serviceContasPagar)
        {
            _serviceContasPagar = serviceContasPagar;
        }

        // GET: api/ContasPagarEntities
        [HttpGet]
        public async Task<IEnumerable<ContasPagarEntity>> GetAllAsync()
        {
            var result = await _serviceContasPagar.ListAsync();

            return result;
        }

        // POST: api/ContasPagarEntities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void PostCliente(ContasPagarEntity contasPagar)
        {
            _serviceContasPagar.Incluir(contasPagar);
        }

    }
}
