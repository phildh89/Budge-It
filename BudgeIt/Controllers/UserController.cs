using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgeIt.Models;

namespace BudgeIt.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserReg(int id = 0)
        {
            UserInfo user = new UserInfo();
            return View();
        }
        [HttpPost]
        public IActionResult UserReg(UserInfo user)
        {
            using (BudgeItDatabaseContext db = new BudgeItDatabaseContext())
            {
                //Prevents accounts to have same emails
                if (db.UserInfo.Any(x => x.Email == user.Email))
                {
                    ViewBag.DuplicateMessage = "Email already been taken";
                    return View("UserReg", user);
                }
                else
                {
                    db.UserInfo.Add(user);
                    db.SaveChanges();
                }
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Your account has been created!";
            return View("UserReg", new UserInfo()); //TODO: Route user to log in screen after success
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Authorize(UserInfo user)
        {
            using (BudgeItDatabaseContext db = new BudgeItDatabaseContext())
            {
                var userDetail = db.UserInfo.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
                if (userDetail == null)
                {
                    ViewBag.LoginError = "Invalid Email and Password";
                    return View("Login", user);
                }
                else
                {
                    //Session["userID"] = user.UserID;
                }
            }
            return View();
        }
    }



}