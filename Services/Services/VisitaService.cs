using Core.DTOs;
using Core.Models;
using Data.Contracts;
using Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    public class VisitaService : IVisitaService
    {
        private readonly IVisitaRepository _visitaRepository;

        public VisitaService(IVisitaRepository visitaRepository)
        {
            _visitaRepository = visitaRepository;
        }

        public Task<IEnumerable<Visita>> Get()
        {
            return _visitaRepository.Get();
        }

        public async Task<Visita> Post(VisitaPostDto visitaPostDto)
        {
            var visita = new Visita()
            {
                Nombre = visitaPostDto.Nombre,
                Empresa = visitaPostDto.Empresa,
                Placas = visitaPostDto.Placas,
                Atencion = visitaPostDto.Atencion,
                Temperatura = visitaPostDto.Temperatura,
                Poliza = visitaPostDto.Poliza,
                FechaEntrada = visitaPostDto.FechaEntrada,
                FechaSalida = visitaPostDto.FechaSalida
            };

            return await _visitaRepository.Store(visita);
        }
    }
}
