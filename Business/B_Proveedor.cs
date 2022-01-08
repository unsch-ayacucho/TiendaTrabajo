using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Proveedor
    {
        public List<ProveedorEntity> ProveedorList()
        {
            using (var db = new TiendaContext())
            {
                return db.Proveedor.ToList();
            }
        }

        public void CrearProveedor(ProveedorEntity oProveedor)
        {
            using (var db = new TiendaContext())
            {
                db.Proveedor.Add(oProveedor);
                db.SaveChanges();
            }
        }

        public void ActualizarProveedor(ProveedorEntity oProveedor)
        {
            using (var db = new TiendaContext())
            {
                db.Proveedor.Update(oProveedor);
                db.SaveChanges();
            }
        }

    }
}
