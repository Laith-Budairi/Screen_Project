using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.Models
{
    public class Event
    {
        public int Id { get; set; }

        public int TemplateId { get; set; }
        public Template CurrentTemplate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Priority { get; set; }

        public string Repeat { get; set; }


        public ICollection<EventProperties> EventsProperties { get; set; }

    }
}
