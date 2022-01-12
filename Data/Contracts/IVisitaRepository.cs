using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface IVisitaRepository
    {
        Task<Visita> Store(Visita visita);
        Task<IEnumerable<Visita>> Get();
    }
}
