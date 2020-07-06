using Microsoft.AspNetCore.Mvc;
using Workspace.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Workspace.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // vmHomeIndex model = new vmHomeIndex();
            vmHomeIndex model = new vmHomeIndex();

            
            //model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
            //model.HtmlSection = System.Net.WebUtility.HtmlDecode(s);
            return View(model);
        }
       

            public IActionResult fixme()
        {
            // vmHomeIndex model = new vmHomeIndex();
            vmHomeIndex model = new vmHomeIndex();

            
            //model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
            //model.HtmlSection = System.Net.WebUtility.HtmlDecode(s);
            return View(model);
        }
        public IActionResult disint()
        {
            // vmHomeIndex model = new vmHomeIndex();
            vmHomeIndex model = new vmHomeIndex();

            //model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
            // model.HtmlSection = System.Net.WebUtility.HtmlDecode(s);
            return View(model);
        }

        public IActionResult newsolution()
        {
   
            vmHomeIndex model = new vmHomeIndex();

        
        //model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
        //model.HtmlSection = System.Net.WebUtility.HtmlDecode(s);

            return View(model);
        }
        public IActionResult solution()
        {
            vmHomeIndex model = new vmHomeIndex();

            return View(model);
        }
    public IActionResult Devsolution()
        {
            vmHomeIndex model = new vmHomeIndex();
            return View(model);
        }
    public IActionResult solutionv1()
    
        {
            vmHomeIndex model = new vmHomeIndex();
    
        //model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
        //model.HtmlSection = System.Net.WebUtility.HtmlDecode(s);

            return View(model);
        }
    public IActionResult tester()
        {
            vmHomeIndex model = new vmHomeIndex();
            return View(model);
        }
       // public IActionResult Portal()
    public IActionResult tc()
        {
            vmHomeIndex model = new vmHomeIndex();

          
            //model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
            //model.HtmlSection = System.Net.WebUtility.HtmlDecode(////);



            //   model.HtmlSection = "hello world";

            return View(model);
        }
    public IActionResult solutionold()
        {   vmHomeIndex model = new vmHomeIndex();
            return View();     
        }
     public IActionResult alpha()
        {
            return View();     
        }
    public IActionResult AvantTekAlpha()
        {
            return View();
        }
    public IActionResult About()
        {
            return View();
        }
    public IActionResult newSolutionsaved()
        {
            return View();
        }
        public IActionResult dlt01()
        {
            return View();
        }
        public IActionResult solutionAlpha()
    {
        return View();
    }
    }
}
