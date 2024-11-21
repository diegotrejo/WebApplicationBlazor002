using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplicationBlazor002.Models;

namespace WebApplicationBlazor002.Controllers
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

        [HttpGet]
        public IActionResult ListaProductos()
        {
            // acceder a una BDD y leer la lista de productos
            // .....
            var listaProductos = new List<Producto>
            {
                new Producto{ Id=1, Name="PAN", Amount=10, Price=0.15, MinStock=5, MaxStock=100 },
                new Producto{ Id=2, Name="QUESO", Amount=20, Price=3, MinStock=15, MaxStock=200 },
                new Producto{ Id=3, Name="LECHE", Amount=30, Price=0.8, MinStock=25, MaxStock=300 },
                new Producto{ Id=4, Name="ACEITE", Amount=40, Price=1.5, MinStock=35, MaxStock=400 },
                new Producto{ Id=5, Name="ARROZ", Amount=50, Price=0.6, MinStock=45, MaxStock=500 }
            };
            //var totalInventario = listaProductos.Sum(x => x.Price * x.Amount);
            var productos = new ListaProductos { 
                Productos = listaProductos
                //TotalInventario = totalInventario,
            };
            // .....
            // una vez tengo la lista la envío a la VISTA para su despliegue 
            return View(productos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
