using Screen_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_Project.ViewModels
{
    public class TemplatePropertiesViewModel
    {
        public TemplateViewModel CurrentTemplate { get; set; }

        public EventPropertiesViewModel CurrentEventProperty { get; set; }

        public string PropertyName { get; set; }

        public string FontFamily { get; set; }

        public int FontSize { get; set; }

        public string FontColor { get; set; }

        public int Top { get; set; }

        public int Left { get; set; }
    }
}
