using Core.DTOs;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/visitas")]
    [ApiController]
    public class VisitaController : ControllerBase
    {
        private readonly IVisitaService _visitaService;

        public VisitaController(IVisitaService visitaService)
        {
            _visitaService = visitaService;
        }

        // GET: api/<VisitaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Visita>>> Get()
        {
            try
            {
                var data = await _visitaService.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los datos: {ex.Message}");
            }
            
        }

        // GET api/<VisitaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VisitaController>
        [HttpPost]
        public async Task<ActionResult<Visita>> Post([FromBody] VisitaPostDto visitaPostDto)
        {
            try
            {
                var response = await _visitaService.Post(visitaPostDto);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el registro: {ex.Message}");
            }
        }

        // PUT api/<VisitaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VisitaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
