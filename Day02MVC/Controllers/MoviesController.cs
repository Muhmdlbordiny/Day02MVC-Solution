using Day02MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Day02MVC.Controllers
{
    public class MoviesController:Controller
    {
        //Action -> Public Non Static Function
        //Action : has special datatype [ActionResult]
        //public string GetMovie(string id)
        //{
        //    return $"id : {id}";
        //}
        //public string Test()
        //{
        //    return $"Default pass";
        //}
        ///Action parameter Binding 
        ///1.Form <summary>
        /// 2.segment
        /// 3.Query string [Query params]
        /// 4.file
        [HttpGet]
        [ActionName(name:"Hamada")]
        public IActionResult GetMovie(int? id,string name,Movies movies)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Id : {id}";
            //result.ContentType = "text/html";
            //return result;
            return Content($"Id is : {id}","text/html");
        }
        //public IActionResult Test(int? id)
        
        //{
        //    if (id == null)
        //    {
        //        RedirectResult result = new RedirectResult("https://www.Facebook.com");
        //        return result;
        //    }
        //    else
        //    {
        //        RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id = id });
        //        return result;
        //    }
        //}
        //public IActionResult Test01(int?id)
        //{
        //    RedirectResult result;
        //    if (id == 1)
        //    {
        //        result = new RedirectResult("https://www.google.com");
        //    }
        //    else
        //    {
        //        result = new RedirectResult("https://www.Facebook.com");

        //    }
        //    return result;
        //}
    }
}
