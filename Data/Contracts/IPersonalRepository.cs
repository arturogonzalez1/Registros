using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface IPersonalRepository
    {
        Task<Personal> Store(Personal visita);
        Task<IEnumerable<Personal>> Get();
    }
}
