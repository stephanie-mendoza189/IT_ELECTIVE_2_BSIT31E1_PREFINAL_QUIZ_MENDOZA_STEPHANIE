using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    
    private static Dictionary<string, string> _projectComments = new Dictionary<string, string>();

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == "admin" && password == "mendoza")
        {
            return View("Home");
        }
        else
        {
            ViewBag.Error = "Incorrect username or password!";
            return View("Index");
        }
    }

    public IActionResult Home()
    {
        return View();
    }

    public IActionResult TableOfContents()
    {
        return View();
    }

    public IActionResult Project(string name)
    {
        ViewBag.ProjectName = name;

        
        if (_projectComments.ContainsKey(name))
        {
            ViewBag.SavedComment = _projectComments[name];
        }
        else
        {
            ViewBag.SavedComment = "No comments yet.";
        }

        return View("ProjectDetail");
    }

    [HttpPost]
    public IActionResult SubmitComment(string userComment, string projectName)
    {
        if (!string.IsNullOrEmpty(userComment))
        {
           
            _projectComments[projectName] = userComment;
        }

      
        return RedirectToAction("Project", new { name = projectName });
    }
}