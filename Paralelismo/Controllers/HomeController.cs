using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Paralelismo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Paralelismo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Metodo para trabajar el paralelismo.
        public async Task<ActionResult> ProcesosEnParaleleo()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var resultado1 = Proceso1();
            var resutaldo2 = Proceso2("Felipe");

           await Task.WhenAll(resultado1, resutaldo2);

            stopwatch.Stop();

            var duracionEnSegundos = stopwatch.ElapsedMilliseconds / 1000.0;
            ViewBag.Duracion = duracionEnSegundos;
            ViewBag.ResultadosEnparalelo1 = resultado1.Result;
            ViewBag.ResultadosEnparalelo2 = resutaldo2.Result;
            return View("Index");
        }

        private async Task<int> Proceso1()
        {
          return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return 42;
            });
            
        }

        private async Task<string> Proceso2(string v)
        {
           var resultado1 = Task.Run(() => {
               Thread.Sleep(1000);
               return $"Hola, { v}";
           }).ContinueWith((sauludo)=> {
               var resultado2 = $"Ejemplo de Saludo: '{sauludo.Result}'";
               return resultado2;
           });
            return await resultado1;
        }
    }
}
