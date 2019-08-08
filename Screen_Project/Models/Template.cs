using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.Models
{
    public class Template
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Background { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<TemplateProperties> TemplatesProperties { get; set; }


    }
}
