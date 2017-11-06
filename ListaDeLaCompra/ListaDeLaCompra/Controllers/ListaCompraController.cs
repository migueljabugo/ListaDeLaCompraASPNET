using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ListaDeLaCompra.Controllers
{
    public class ListaCompraController : Controller
    {

        public ActionResult Index()
        {
            List<Models.ListaCompra> tareas = Models.ListaCompra.Listar();
            return View(tareas);
        }


        public ActionResult Ver(int id)
        {
            Models.ListaCompra producto = Models.ListaCompra.GetProducto(id);

            return View(producto);
        }







    }
}
