using Microsoft.AspNetCore.Mvc;
using ModelliMeteo;
using Newtonsoft.Json;
using ServiziMeteo;
using WebAppProgettoEsame.ViewModels;

namespace WebAppProgettoEsame.Controllers
{
    public class MeteoController : Controller
    {
        public IActionResult Index()
        {
            RootMeteo meteo = ServiziMeteo.ServiziMeteo.DaiMeteo();

            MeteoViewModel vm = new MeteoViewModel
            {
                Meteo = meteo 
            };
            return View(vm);
        }
    }
}
