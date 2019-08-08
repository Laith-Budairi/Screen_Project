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
    public class TemplatePropertiesController : ControllerBase
    {
        private readonly ScreenContext _context;

        private readonly IMapper _mapper;
        private readonly ITemplatePropertiesRepo _templatePropertiesRepo;

        public TemplatePropertiesController(ScreenContext context, IMapper mapper, ITemplatePropertiesRepo eventRepo)
        {
            _context = context;
            _mapper = mapper;
            _templatePropertiesRepo = eventRepo;
        }

        // GET: api/TemplateProperties
        [HttpGet]
        public async Task<List<TemplateProperties>> GetTemplatesProperties()
        {
            return await _templatePropertiesRepo.GetAll();
        }

        // GET: api/TemplateProperties/5
        [HttpGet("{id}")]
        public async Task<TemplateProperties> GetTemplateProperties(int id)
        {
            var template = await _templatePropertiesRepo.GetAsync(id);

            return template;
        }

        // PUT: api/TemplateProperties/5
        [HttpPut("{id}")]
        public async Task<TemplateProperties> PutTemplateProperties(int id, TemplateProperties template)
        {
            return await _templatePropertiesRepo.UpdateAsync(id, template);
        }

        // POST: api/TemplateProperties
        [HttpPost]
        public async Task<TemplateProperties> PostTemplateProperties(TemplateProperties template)
        {
            return await _templatePropertiesRepo.AddAsync(template);

        }

        // DELETE: api/TemplateProperties/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteTemplateProperties(int id, TemplateProperties t)
        {
            return await _templatePropertiesRepo.RemoveAsync(id, t);
        }

        private bool TemplatePropertiesExists(int id)
        {
            return _context.TemplatesProperties.Any(e => e.Id == id);
        }
    }
}
