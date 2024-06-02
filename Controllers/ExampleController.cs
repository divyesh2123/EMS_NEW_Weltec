using EMS.BussinessEnitiy;
using EMS.BussinessService.Concreate;
using EMS.BussinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS_NEW_Weltec.Controllers
{
    public class ExampleController : Controller
    {
        private readonly IUserService _userService;
        public ExampleController(IUserService userService)
        {
            _userService = userService;
        }
        public ViewResult Index()
        {
            return View();
        }

       

        public JsonResult GetData()
        {
            return Json(new { data = _userService.GetUsers() });

           
        }

        public PartialViewResult AddEditUser()
        {

            return PartialView("AddEditForm");   
        }

        [HttpPost]
        public JsonResult SaveUser(UserViewModel userViewModel)
        {
            var d = _userService.AddUser(userViewModel);
            return Json(new { result = d, message = "Save info" });
        }

        [HttpPost]
        public JsonResult DeleteInfo(int id)
        {
            var d = _userService.DeleteUser(id);


            return Json(new { result = d, message = "deleted info" });
        }
    }
}
