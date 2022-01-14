using Core.DTOs;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IPersonalService
    {
        Task<Personal> Post(PersonalPostDto visitaPostDto);
        Task<IEnumerable<Personal>> Get();
    }
}
