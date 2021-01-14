using Api.BussinesLogic;
using Api.Database.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Services
{
    [Route("[controller]")]
    [ApiController]
    public class ContasPagarController : ControllerBase
    {
        private readonly IContasPagarBll _serviceContasPagar;

        public ContasPagarController(IContasPagarBll serviceContasPagar)
        {
            _serviceContasPagar = serviceContasPagar;
        }

        // GET: api/ContasPagarEntities
        [HttpGet]
        public IEnumerable<ContasPagarEntity> Get()
        {
            return _serviceContasPagar.Listar(); ;
        }

        // POST: api/ContasPagarEntities
        [HttpPost]
        public string Post([FromBody] ContasPagarEntity contasPagar)
        {
            return _serviceContasPagar.Incluir(contasPagar);
        }
    }
}
