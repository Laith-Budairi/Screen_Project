using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.Models
{
    public class TemplateProperties
    {
        public int Id { get; set; }

        public int TemplateId { get; set; }
        public Template CurrentTemplate { get; set; }

        public EventProperties CurrentEventProperty { get; set; }

        public string PropertyName { get; set; }

        public string FontFamily { get; set; }

        public int FontSize { get; set; }

        public string FontColor { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }
    }

}
