using BankApp.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace BankApp.Controllers
{
    public class BankController : Controller
    {
        private ApplicationDbContext _context;

        public BankController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var user = User.Identity.GetUserName();
            var currentLogedUser = _context.Users.ToList().Where(m => m.UserName == user);
            return View(currentLogedUser);
        }

        public ActionResult Transfer()
        {
            return View();
        }
    }
}