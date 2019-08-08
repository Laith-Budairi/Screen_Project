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
    public class TemplatesController : ControllerBase
    {
        private readonly ScreenContext _context;
        private readonly IMapper _mapper;
        private readonly ITemplateRepo _templateRepo;

        public TemplatesController(ScreenContext context, IMapper mapper, ITemplateRepo templateRepo)
        {
            _context = context;
            _mapper = mapper;
            _templateRepo = templateRepo;
        }

        // GET: api/Templates
        [HttpGet]
        public async Task<List<Template>> GetTemplates()
        {
            return await _templateRepo.GetAll();
        }

        // GET: api/Templates/5
        [HttpGet("{id}")]
        public async Task<Template> GetTemplate(int id)
        {
            var template = await _templateRepo.GetAsync(id);

            return template;
        }

        // PUT: api/Templates/5
        [HttpPut("{id}")]
        public async Task<Template> PutTemplate(int id, Template template)
        {
            return await _templateRepo.UpdateAsync(id, template);
        }

        // POST: api/Templates
        [HttpPost]
        public async Task<Template> PostTemplate(Template template)
        {
            return await _templateRepo.AddAsync(template);

        }

        // DELETE: api/Templates/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteTemplate(int id, Template t)
        {
            return await _templateRepo.RemoveAsync(id, t);
        }

        private bool TemplateExists(int id)
        {
            return _context.Templates.Any(e => e.Id == id);
        }
    }
}
