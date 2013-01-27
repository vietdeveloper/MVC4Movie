using System.Web.Mvc;
using System.Web;

namespace Mvc4Movie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        //
        // GET: /HelloWord/Welcome/

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello "+name+", NumTimes is: "+numTimes);
        }
    }
}
