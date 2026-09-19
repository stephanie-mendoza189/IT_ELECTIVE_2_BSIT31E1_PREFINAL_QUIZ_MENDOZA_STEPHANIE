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
        if (username == "admin" && password == "secret123")
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
        return View("ProjectDetail");
    }

    
    [HttpPost]
    public IActionResult SubmitComment(string userComment, string projectName)
    {
        if (userComment != null && userComment != "")
        {
            ViewBag.SavedComment = userComment;
        }
        else
        {
            ViewBag.SavedComment = "Comment cannot be empty!";
        }
        ViewBag.ProjectName = projectName;
        return View("ProjectDetail");
    }
}