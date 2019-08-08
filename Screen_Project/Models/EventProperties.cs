using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.Models
{
    public class EventProperties
    {
        public int Id { get; set; }

        public int TemplatePropertyId { get; set; }
        public TemplateProperties CurrentTemplateProperty { get; set; }


        public int EventId { get; set; }
        public Event CurrentEvent { get; set; }

        public string PropertyType { get; set; }

        public string PropertyValue { get; set; }





    }
}
