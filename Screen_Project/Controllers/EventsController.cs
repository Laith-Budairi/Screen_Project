using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Screen_Project;
using Screen_Project.Interfaces;
using Screen_Project.Models;
using Screen_Project.ViewModels;

namespace Screen_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly ScreenContext _context;
        private readonly IMapper _mapper;
        private readonly IEventRepo _eventRepo;
        private readonly IOptions<EventConfig> _option;

        public EventsController(ScreenContext context, IMapper mapper, IEventRepo eventRepo, IOptions<EventConfig> option)
        {
            _context = context;
            _mapper = mapper;
            _eventRepo = eventRepo;
            _option = option;
        }


        // GET: api/Events
        [HttpGet]
        public async Task<List<EventViewModel>> GetEvents()
        {
            List<EventViewModel> events = _mapper.Map<List<EventViewModel>>(_eventRepo.GetEventsToday());

            return events;
        }

        [HttpGet("eventconfig")]
        public EventConfig Events()
        {
            return _option.Value;
        }

        // GET: api/Events/5
        public async Task<Event> GetEvent(int id)
        {
            var e = await _eventRepo.GetAsync(id);

            return e;
        }

        // PUT: api/Events/5
        [HttpPut("{id}")]
        public async Task<Event> PutEvent(int id, Event e)
        {
            return await _eventRepo.UpdateAsync(id, e);
        }

        // POST: api/Events
        [HttpPost]
        public async Task<Event> PostEvent(Event e)
        {
            return await _eventRepo.AddAsync(e);

        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteEvent(int id, Event e)
        {
            return await _eventRepo.RemoveAsync(id, e);
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
