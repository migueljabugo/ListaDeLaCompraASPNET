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


        public ActionResult Ver(int id=0)
        {
            if (id!=0)
            {
                Models.ListaCompra producto = Models.ListaCompra.GetProducto(id);
                if (producto!=null)
                {
                    return View(producto);
                }
                else
                {
                    return Redirect("~/");
                }
            }
            else
            {
                return Redirect("~/");
            }
            
        }

        public ActionResult Crear()
        {
            Models.ListaCompra listacompra = new Models.ListaCompra();
            return View("productoForm", listacompra);
        }

        public ActionResult Guardar(Models.ListaCompra listacompra)
        {
            listacompra.Save();
            return Redirect("~/ListaCompra/ver/"+ listacompra.id);
           
        }

        public ActionResult Modificar(int id=0)
        {
            if (id!=0)
            {
                Models.ListaCompra producto = Models.ListaCompra.GetProducto(id);
                return View("productoForm", producto);
            }
            else
            {
                return Redirect("~/");
            }
        }

        public ActionResult Eliminar(int id=0)
        {
            Models.ListaCompra listaCompra = Models.ListaCompra.GetProducto(id);
            listaCompra.Eliminar();
            return Redirect("~/");
        }

        public ActionResult Comprados()
        {
            List<Models.ListaCompra> tareas = Models.ListaCompra.Listar().Where(x => x.comprado == true).ToList();
            return View("Index", tareas);
        }

        





    }
}
