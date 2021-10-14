using ApiGestor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace ApiGestor.Services
{

    public interface IPacienteService
    {
        public IEnumerable<Paciente> getPacientes();
        public IEnumerable<Paciente> addPaciente(Paciente paciente);
    }
    public class PacienteService : IPacienteService
    {
        static List<Paciente> pacientes = new List<Paciente>();

        public IEnumerable<Paciente> getPacientes()
        {
            return pacientes;
        }

        public IEnumerable<Paciente> addPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
            return pacientes;
        }
    }
}
