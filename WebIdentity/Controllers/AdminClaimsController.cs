using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebIdentity.Controllers
{
    public class AdminClaimsController : Controller
    {
        private UserManager<IdentityUser> _userManager;

        public AdminClaimsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users;
            return View(users);
        }
    }
}
