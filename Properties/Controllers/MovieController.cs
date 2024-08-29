using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace C42_G02_MVC0_2.Properties.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult GetMovie(int[]arr)
        {
           /* ContentResult result = new ContentResult();
            result.Content = $"Movie with id={id}";
            result.ContentType = "object/pdf";
            result.StatusCode = 200;*/

            return Content($"Movie with id={arr[0]}","txt/html") ;
        }
        public IActionResult Index() {
            //  RedirectResult redirect=new RedirectResult("https//localhost:44323/Movie/GetMovie/10");
            //   return RedirectToAction(nameof(GetMovie), new { id=10}) ;
            return RedirectToRoute("default", new { Controller = "product", action = "GetProduct", id = 100 });
        }
    }
}
