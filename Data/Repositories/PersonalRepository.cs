using Core.Models;
using Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonalRepository : IPersonalRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Personal>> Get()
        {
            return await _context.Personal.ToListAsync();
        }

        public Task<Personal> Store(Personal visita)
        {
            throw new NotImplementedException();
        }
    }
}
