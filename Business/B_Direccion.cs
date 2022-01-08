using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Direccion
    {
        public List<DireccionEntity> DireccionList()
        {
            using (var db = new TiendaContext())
            {
                return db.Direccion.ToList();
            }
        }

        public void CrearDireccion(DireccionEntity oDireccion)
        {
            using (var db = new TiendaContext())
            {
                db.Direccion.Add(oDireccion);
                db.SaveChanges();
            }
        }

        public void ActualizarDireccion(DireccionEntity oDireccion)
        {
            using (var db = new TiendaContext())
            {
                db.Direccion.Update(oDireccion);
                db.SaveChanges();
            }
        }

    }
}
