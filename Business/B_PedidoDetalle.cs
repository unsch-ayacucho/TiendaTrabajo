using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_PedidoDetalle
    {
        public List<PedidoDetalleEntity> PedidoDetalleList()
        {
            using (var db = new TiendaContext())
            {
                return db.PedidoDetalle.ToList();
            }
        }

        public void CrearPedidoDetalle(PedidoDetalleEntity oPedidoDetalle)
        {
            using (var db = new TiendaContext())
            {
                db.PedidoDetalle.Add(oPedidoDetalle);
                db.SaveChanges();
            }
        }

        public void ActualizarPedidoDetalle(PedidoDetalleEntity oPedidoDetalle)
        {
            using (var db = new TiendaContext())
            {
                db.PedidoDetalle.Update(oPedidoDetalle);
                db.SaveChanges();
            }
        }

    }
}
