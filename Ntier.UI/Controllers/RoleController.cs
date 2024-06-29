using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ntier.Data.Models.Identity;

namespace Ntier.UI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            if (_roleManager.Roles.ToList() == null)
                return NotFound("Roles is not found!!!");
            return View(_roleManager.Roles.Where(x => x.Name != "Admin").ToList());
        }
    }
}
