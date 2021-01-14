using Api.Domain.Models;
using Api.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<ContasPagarEntity> Get()
        {
            return _serviceContasPagar.Listar(); ;
        }
    }
}
