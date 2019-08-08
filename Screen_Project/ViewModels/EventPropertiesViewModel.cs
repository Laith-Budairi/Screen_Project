using Screen_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.ViewModels
{
    public class EventPropertiesViewModel
    {
        public TemplatePropertiesViewModel CurrentTemplateProperty { get; set; }

        public EventViewModel CurrentEvent { get; set; }

        public string PropertyType { get; set; }

        public string PropertyValue { get; set; }

    }
}
