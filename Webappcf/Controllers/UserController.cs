using System.Linq;
using System.Web.Mvc;
using Webappcf.Business;
using Webappcf.Entities;

namespace Webappcf.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: User
        public ActionResult Index()
        {
            return View(_userService.GetAllUsers());
        }
    }
}
