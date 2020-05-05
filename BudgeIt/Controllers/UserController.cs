using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgeIt.Models;
using System.Web;


namespace BudgeIt.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserReg(int id)
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
            return View("Login", new UserInfo()); //TODO: Route user to log in screen after success
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
                    //TODO: Troubleshoot user session
                    //Session["userId"] = user.UserId;
                    //This displays first name on home page
                    //Session["firstName"] = user.firstName;
                    return RedirectToAction("Index", "Home");
                    //TODO: Add to _Layout to redirect to login if no logged in
                    //if (Session["userId"] == null)
                    //{
                    //    Response.Redirect("~/User/Login");
                    //}

                }
            }
        }
        public IActionResult LogOut()
        {
            //TODO: Uncomment after fixing session error
            //int userId = (int) Session["userId"];
            //Session.Abandon();
            return RedirectToAction("Login","User");
        }
    }



}