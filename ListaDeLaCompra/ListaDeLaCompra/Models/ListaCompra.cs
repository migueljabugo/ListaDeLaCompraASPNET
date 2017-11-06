namespace ListaDeLaCompra.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using ListaDeLaCompra.Models;
    using System.Linq;

    [Table("ListaCompra")]
    public partial class ListaCompra
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string producto { get; set; }

        public bool comprado { get; set; }


        public static List<Models.ListaCompra> Listar()
        {
            List<ListaCompra> listaCompra = new List<ListaCompra>();

            try
            {
                ListaCompraContext context = new ListaCompraContext();
                listaCompra = context.ListaCompra.ToList();
            }
            catch (Exception e)
            {
                throw;
            }
            return listaCompra;
        }

        public static Models.ListaCompra GetProducto( int id)
        {
            ListaCompra producto = null;

            try
            {
                ListaCompraContext context = new ListaCompraContext();
                producto = context.ListaCompra.Where(x => x.id == id).SingleOrDefault();
            }
            catch (Exception e)
            {
                throw;
            }
            return producto;

        }


    } 
}
