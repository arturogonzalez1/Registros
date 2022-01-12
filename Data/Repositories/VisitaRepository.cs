using Core.Models;
using Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class VisitaRepository : IVisitaRepository
    {
        private readonly ApplicationDbContext _context;

        public VisitaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Visita>> Get()
        {
            return await _context.Visitas.ToListAsync();
        }

        public async Task<Visita> Store(Visita visita)
        {
            await _context.Visitas.AddAsync(visita);
            await _context.SaveChangesAsync();
            return visita;
        }
    }
}
