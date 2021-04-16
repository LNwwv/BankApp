using System.Linq;
using BankApp.Models;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace BankApp.Api
{
    public class BankApiController : ApiController
    {
        private ApplicationDbContext _context;

        public BankApiController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        [Route("api/transfer")]
        public IHttpActionResult SendTransfer(Transfer transfer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok("Jest git");
        }

        [HttpGet]
        [Route("api/accNumber")]
        public IHttpActionResult GetAccountNumber()
        {
            string currentLogedUserId = User.Identity.GetUserId();
            var account = _context.Users.ToList()
                .Where(m => m.Id == currentLogedUserId)
                .Select(m => m.BankAccountNumber);

            return Ok(account);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
