using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workspace.ViewModels;
using System.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Workspace.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            vmHomeIndex model = new vmHomeIndex();

            string s = @"<form style=""padding-top: 50px"" novalidate name=""myForm"" class=""form-inline"" role=""form"" ng-submit=""vm.SendGridAlphaInterested(vm.email.text)"">\r\n
            <div class=""form-group"" ng-class=""{'has-error' : myForm.input.$invalid && myForm.input.$dirty}"">\r\n
                @*<label for=""input"" class=""col-sm-3 control-label"">Email</label>*@\r\n
                <div class=""row"">
                    <span class=""col-md-4 md-offset-3"">
                        <input type=""email"" name=""input"" class=""input-lg form-control"" ng-model=""vm.email.text"" ng-required=""true"">
                    </span>
                    <span class=""col-md-2"">
                        <button ng-click='validateEmail()' type=""submit"" class=""btn btn-primary"">Subscribe</button>
                    </span>
                    <span class=""col-md-3""></span>
                </div>
                <div class=""row"">
                    <div id=""emErr"" class=""col-md-12"" ng-show=""myForm.input.$invalid && myForm.input.$dirty"" style=""font-size: 20px"">A valid email is required</div>
                    @*<span ng-show=""myForm.input.$invalid && myForm.input.$dirty "">A valid email is required</span>*@
                </div>
            </div>
        </form>";

            model.HtmlSection = System.Web.HttpUtility.HtmlDecode(s);
         //   model.HtmlSection = "hello world";

            return View(model);
        }
        public IActionResult LearnToClick()
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
    }
}
