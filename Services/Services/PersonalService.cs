using Core.DTOs;
using Core.Models;
using Data.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PersonalService : IPersonalService
    {
        private readonly IPersonalRepository _personalRepository;

        public PersonalService(IPersonalRepository personalRepository)
        {
            _personalRepository = personalRepository;
        }

        public Task<IEnumerable<Personal>> Get()
        {
            return _personalRepository.Get();
        }

        public Task<Personal> Post(PersonalPostDto visitaPostDto)
        {
            throw new NotImplementedException();
        }
    }
}
