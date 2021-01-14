﻿using Api.Database.Contexts;
using Api.Database.Models;
using System.Collections.Generic;

namespace Api.Database.Repositories
{
    public class ContasPagarRepository: BaseRepository, IContasPagarRepository
    {
        public ContasPagarRepository(AppDbContext context) : base(context)
        {

        }

        public void Add(ContasPagarEntity contas)
        {
             _context.ContasPagar.AddAsync(contas);

            _context.SaveChanges();
        }

        public IEnumerable<ContasPagarEntity> Listar()
        {
            return _context.ContasPagar;
        }
    }
}
