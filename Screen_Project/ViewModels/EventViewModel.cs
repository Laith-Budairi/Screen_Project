using Screen_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.ViewModels
{
    public class EventViewModel
    {
        public TemplateViewModel CurrentTemplate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Priority { get; set; }

        public string Repeat { get; set; }

        public ICollection<EventPropertiesViewModel> EventsProperties { get; set; }
    }
}
