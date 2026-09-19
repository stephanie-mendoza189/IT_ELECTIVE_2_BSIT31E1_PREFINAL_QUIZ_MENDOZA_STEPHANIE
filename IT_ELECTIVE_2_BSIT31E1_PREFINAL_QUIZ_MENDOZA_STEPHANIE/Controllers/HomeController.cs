using System.Diagnostics;
using IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_MENDOZA_STEPHANIE.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_BSIT31E1_PREFINAL_QUIZ_MENDOZA_STEPHANIE.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View(); 
        }

       
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            
            if (username == "admin" && password == "mendoza")
            {
                
                return View("TableOfContents");
            }
            else
            {
               
                ViewBag.Error = "Incorrect username or password!";
                return View("Index");
            }
        }

        
        public IActionResult TableOfContents()
        {
            return View();
        }



        
        public IActionResult ProjectOne()
        {
            return View();
        }

        public IActionResult ProjectTwo()
        {
            return View();
        }

        public IActionResult ProjectThree()
        {
            return View();
        }

        public IActionResult ProjectFour()
        {
            return View();
        }

        public IActionResult ProjectFive()
        {
            return View();
        }

        public IActionResult ProjectSix()
        {
            return View();
        }

        public IActionResult ProjectSeven()
        {
            return View();
        }

        








        public IActionResult ProjectOnee()
        {
            return View();
        }

        public IActionResult ProjectTwoo()
        {
            return View();
        }

        public IActionResult ProjectThreee()
        {
            return View();
        }

        public IActionResult ProjectFourr()
        {
            return View();
        }

        public IActionResult ProjectFivee()
        {
            return View();
        }

        public IActionResult ProjectSixx()
        {
            return View();
        }

        public IActionResult ProjectSevenn()
        {
            return View();
        }




















        public IActionResult ProjectOneee()
        {
            return View();
        }

        public IActionResult ProjectTwooo()
        {
            return View();
        }

        public IActionResult ProjectThreeee()
        {
            return View();
        }




        [HttpPost]
        public IActionResult SubmitComment(string userComment)
        {
            if (userComment != null && userComment != "")
            {
                ViewBag.SavedComment = userComment;
            }
            else
            {
                ViewBag.SavedComment = "Comment cannot be empty!";
            }

            return View("ProjectOne");
        }
    }
    }
