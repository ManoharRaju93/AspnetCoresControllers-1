using Microsoft.AspNetCore.Mvc;

namespace AspnetCoresControllers_1.Controllers
{
    public class HomeController
    {
     [Route("home")]
      [Route("/")]
        public string method1()
        {
            return "hello from the controller method";
        }
    }
}
