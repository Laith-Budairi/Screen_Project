using Screen_Project.Interfaces;
using Screen_Project.Models;
using WebApplication1.Helpers;

namespace Screen_Project.Helpers
{
    public class EventPropertiesRepo : BaseRepo<EventProperties>, IEventPropertiesRepo
    {
        ScreenContext Context;
        public EventPropertiesRepo(ScreenContext Context) : base(Context)
        {
           this.Context = Context;
        }

    }
}
