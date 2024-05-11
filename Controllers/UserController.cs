using EMS.BussinessService.Concreate;
using EMS.BussinessService.Interface;
using EMS_New.Repository.Concreate;
using EMS_New.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS_NEW_Weltec.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController()
        {
            userService = new UserService();
        }

        public IActionResult Index()
        {
            var p = userService.GetUsers();
            return View(p);
        }
    }
}
