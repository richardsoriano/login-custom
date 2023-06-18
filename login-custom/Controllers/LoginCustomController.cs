using login_custom.Models;
using Microsoft.AspNetCore.Mvc;

namespace login_custom.Controllers
{
    public class LoginCustomController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginCustomController(ApplicationDbContext db) { _db = db}
        public IActionResult Index()
        {
            return View();
        }
    }
}
