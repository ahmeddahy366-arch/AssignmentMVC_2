using Assignment_MVC_2.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;

namespace AssignmentMVC_2.Controllers
{
    public class PlanController : Controller
    {
        public async Task<IActionResult> Index()
        {
             using GymDbContext gymDbContext= new GymDbContext ();
            var plans = await gymDbContext.Plans.ToListAsync();
            return View(plans);

        }

    }
}
