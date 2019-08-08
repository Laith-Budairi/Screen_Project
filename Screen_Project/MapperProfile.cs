using AutoMapper;
using Screen_Project.Models;
using Screen_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Template, TemplateViewModel>();
            CreateMap<TemplateProperties, TemplatePropertiesViewModel>();
            CreateMap<Event, EventViewModel>();
            CreateMap<EventProperties, EventPropertiesViewModel>();
        }
    }
}
