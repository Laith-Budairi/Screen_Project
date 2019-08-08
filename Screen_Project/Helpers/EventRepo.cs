using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Screen_Project.Interfaces;
using Screen_Project.Models;
using Screen_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Helpers;

namespace Screen_Project.Helpers
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {
        ScreenContext Context;
        public EventRepo(ScreenContext Context) : base(Context)
        {
            this.Context = Context;
        }

        public List<Event> GetEventsToday()
        {


            //var x = Context.Set<Event>().Where(e => DateTime.UtcNow.Date == e.StartDate.Date
            //|| e.Repeat.Equals("Daily") ||(e.Repeat.Equals("Monthly"))).Include(ep => ep.EventsProperties).ThenInclude(a => a.CurrentTemplateProperty)
            //.ThenInclude(a => a.CurrentTemplate).ToList();

            var x = Context.Set<Event>().Where(e => (e.StartDate.Date == DateTime.UtcNow.Date
           || e.Repeat == "daily"
           || (e.Repeat == "monthly" && e.StartDate.Date.Day == DateTime.UtcNow.Day)
           || (e.Repeat == "yearly") && (e.StartDate.Date.Day == DateTime.UtcNow.Day) && (e.StartDate.Date.Month == DateTime.UtcNow.Month))).Include(ep => ep.EventsProperties).ThenInclude(a => a.CurrentTemplateProperty)
            .ThenInclude(a => a.CurrentTemplate).ToList();

            return x;
        }

    }
}
