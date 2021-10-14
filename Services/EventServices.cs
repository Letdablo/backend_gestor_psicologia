using ApiGestor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace ApiGestor.Services
{

    public interface IEventosService
    {
        public IEnumerable<Event> getEventosByDate(DateTime minfecha, DateTime maxFecha);
        public IEnumerable<Event> addEventosByDate(Event evento);
    }
    public class EventServices : IEventosService
    {
        static List<Event> events = new List<Event>();

        public IEnumerable<Event> addEventosByDate(Event evento)
        {
            events.Add(evento);
            return events;
        }

        public IEnumerable<Event> getEventosByDate(DateTime minfecha, DateTime maxFecha)
        {
            var filtered = new List<Event>();
            foreach (var e in events)
            {
                if (DateTime.Compare(minfecha, e.Date) <= 0)
                    if (DateTime.Compare(e.Date, maxFecha)<=0)
                    {
                        filtered.Add(e);
                    }
            }
            return filtered;
        }
    }
}
