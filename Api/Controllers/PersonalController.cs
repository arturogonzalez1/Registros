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
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private readonly IPersonalService _personalService;

        public PersonalController(IPersonalService personalService)
        {
            _personalService = personalService;
        }

        // GET: api/<PersonalController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personal>>> Get()
        {
            try
            {
                var data = await _personalService.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener los datos: {ex.Message}");
            }
        }

        // GET api/<PersonalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonalController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
