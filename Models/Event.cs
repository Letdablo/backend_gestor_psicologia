using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGestor.Models
{
    public class Event
    {
        public DateTime Date { get; set; }

        public string Color { get; set; }

        public string Title { get; set; }

        public int Duracion { get; set; }

        public string Place { get; set; }

        public int[] UserID { get; set; }


    }



}
