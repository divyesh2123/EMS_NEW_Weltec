using EMS.BussinessService.Concreate;
using EMS.BussinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS_NEW_Weltec.Controllers
{
    public class ExampleController : Controller
    {
        private readonly IUserService userService;
        public ExampleController()
        {
            userService = new UserService();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            return Json(new { data =  userService.GetUsers() });

           
        }
    }
}
