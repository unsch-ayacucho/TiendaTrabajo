using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Producto
    {
        public List<ProductoEntity> ProductoList()
        {
            using (var db = new TiendaContext())
            {
                return db.Producto.ToList();
            }
        }

        public void CrearProducto(ProductoEntity oProducto)
        {
            using (var db = new TiendaContext())
            {
                db.Producto.Add(oProducto);
                db.SaveChanges();
            }
        }

        public void ActualizarProducto(ProductoEntity oProducto)
        {
            using (var db = new TiendaContext())
            {
                db.Producto.Update(oProducto);
                db.SaveChanges();
            }
        }

    }
}
