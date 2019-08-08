using Screen_Project.Interfaces;
using Screen_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Helpers;

namespace Screen_Project.Helpers
{
    public class TemplateRepo : BaseRepo<Template> , ITemplateRepo {

        ScreenContext Context;
        public TemplateRepo(ScreenContext Context) : base(Context)
        {
            this.Context = Context;
        }
    }
}
