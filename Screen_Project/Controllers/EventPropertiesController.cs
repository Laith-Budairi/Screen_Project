using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Screen_Project;
using Screen_Project.Interfaces;
using Screen_Project.Models;

namespace Screen_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventPropertiesController : ControllerBase
    {
        private readonly ScreenContext _context;
        private readonly IMapper _mapper;
        private readonly IEventPropertiesRepo _eventPropertiesRepo;

        public EventPropertiesController(ScreenContext context, IMapper mapper, IEventPropertiesRepo eventRepo)
        {
            _context = context;
            _mapper = mapper;
            _eventPropertiesRepo = eventRepo;
        }

        // GET: api/EventProperties
        [HttpGet]
        public async Task<List<EventProperties>> GetEventsProperties()
        {
            return await _eventPropertiesRepo.GetAll();
        }

        // GET: api/EventProperties/5
        [HttpGet("{id}")]
        public async Task<EventProperties> GetTemplateProperties(int id)
        {
            var template = await _eventPropertiesRepo.GetAsync(id);

            return template;
        }

        // PUT: api/EventProperties/5
        [HttpPut("{id}")]
        public async Task<EventProperties> PutEventProperties(int id, EventProperties e)
        {
            return await _eventPropertiesRepo.UpdateAsync(id, e);
        }

        // POST: api/EventProperties
        [HttpPost]
        public async Task<EventProperties> PostEventProperties(EventProperties e)
        {
            return await _eventPropertiesRepo.AddAsync(e);

        }

        // DELETE: api/EventProperties/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteEventProperties(int id, EventProperties e)
        {
            return await _eventPropertiesRepo.RemoveAsync(id, e);
        }

        private bool EventPropertiesExists(int id)
        {
            return _context.EventsProperties.Any(e => e.Id == id);
        }
    }
}
