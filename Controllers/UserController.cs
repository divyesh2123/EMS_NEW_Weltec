﻿using EMS.BussinessEnitiy;
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

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(UserViewModel userViewModel)
        {
            userService.AddUser(userViewModel); 
            return RedirectToAction("Index");   
        }

        public IActionResult Index()
        {
            var p = userService.GetUsers();

            if(p.Count == 0)
            {
                ViewData["Message"] = "No Record found";
                ViewBag.Message = "test";
                string d= ViewBag.Message;
                string d1 = Convert.ToString(ViewData["Message"]);
            }
            return View(p);
        }

        public IActionResult DeleteInfo(int id)
        {
             var d = userService.DeleteUser(id);

            TempData["message"] = "User Deleted suc...";

           return RedirectToAction("Index");    
        }
    }
}
