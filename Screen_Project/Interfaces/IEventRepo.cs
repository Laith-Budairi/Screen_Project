using Screen_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Interfaces;

namespace Screen_Project.Interfaces
{
    public interface IEventRepo : IBaseRepo<Event>
    {
        List<Event> GetEventsToday();

    }
}
