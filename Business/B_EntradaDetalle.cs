using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_EntradaDetalle
    {
        public List<EntradaDetalleEntity> EntradaDetalleList()
        {
            using (var db = new TiendaContext())
            {
                return db.EntradaDetalle.ToList();
            }
        }

        public void CrearEntradaDetalle(EntradaDetalleEntity oEntradaDetalle)
        {
            using (var db = new TiendaContext())
            {
                db.EntradaDetalle.Add(oEntradaDetalle);
                db.SaveChanges();
            }
        }

        public void ActualizarEntradaDetalle(EntradaDetalleEntity oEntradaDetalle)
        {
            using (var db = new TiendaContext())
            {
                db.EntradaDetalle.Update(oEntradaDetalle);
                db.SaveChanges();
            }
        }

    }
}
