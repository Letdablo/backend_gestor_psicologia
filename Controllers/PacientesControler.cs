using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGestor.helpers;
using ApiGestor.Models;
using ApiGestor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiGestor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacientesControles : ControllerBase
    {

        private PacienteService pacienteServices = new PacienteService();

        [Authorize]
        [HttpGet]

        public IEnumerable<Paciente> Get()
        {
            return pacienteServices.getPacientes();
        }

        [Authorize]
        [HttpPut]
        public IEnumerable<Paciente> Put(Paciente paciente)
        {
            return pacienteServices.addPaciente(paciente);
        }
    }
}
