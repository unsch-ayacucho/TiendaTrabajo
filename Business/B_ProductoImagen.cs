using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_ProductoImagen
    {
        public List<ProductoImagenEntity> ProductoImagenList()
        {
            using (var db = new TiendaContext())
            {
                return db.ProductoImagen.ToList();
            }
        }

        public void CrearProductoImagen(ProductoImagenEntity oProductoImagen)
        {
            using (var db = new TiendaContext())
            {
                db.ProductoImagen.Add(oProductoImagen);
                db.SaveChanges();
            }
        }

        public void ActualizarProductoImagen(ProductoImagenEntity oProductoImagen)
        {
            using (var db = new TiendaContext())
            {
                db.ProductoImagen.Update(oProductoImagen);
                db.SaveChanges();
            }
        }

    }
}
