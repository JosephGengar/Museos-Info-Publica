using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MuseosArg.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var httpclient = new HttpClient();
            var json = await httpclient.GetStringAsync("https://www.cultura.gob.ar/api/v2.0/museos/");
            var museos = JsonConvert.DeserializeObject(json);
            return View(museos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descripcion del proyecto";

            return View();
        }

    }
}