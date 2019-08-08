using Screen_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.ViewModels
{
    public class TemplateViewModel
    {
        public string Name { get; set; }

        public string Background { get; set; }

        public ICollection<EventViewModel> Events { get; set; }
        public ICollection<TemplatePropertiesViewModel> TemplatesProperties { get; set; }
    }
}
