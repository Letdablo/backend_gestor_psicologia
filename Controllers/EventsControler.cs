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
    public class EventControler : ControllerBase
    {

        private EventServices eventServices = new EventServices();
   

        [Authorize]
        [HttpPost]
        public IEnumerable<Event> Post(EventsRequest model )
        {
            return eventServices.getEventosByDate(model.Minfecha, model.MaxFecha);
        }

        [Authorize]
        [HttpPut]
        public IEnumerable<Event> Put(Event evento)
        {
            return eventServices.addEventosByDate(evento);
        }
    }
}
