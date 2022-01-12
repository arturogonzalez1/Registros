using Core.DTOs;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IVisitaService
    {
        Task<Visita> Post(VisitaPostDto visitaPostDto);
        Task<IEnumerable<Visita>> Get();
    }
}
