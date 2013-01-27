using System.Web.Mvc;
using System.Web;

namespace Mvc4Movie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWord/Welcome/

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello "+name+", NumTimes is: "+numTimes);
        }
    }
}
