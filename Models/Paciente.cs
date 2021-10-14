using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiGestor.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }
        public string Gen { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

    }
}
