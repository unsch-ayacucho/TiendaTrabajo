using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Pedido
    {
        public List<PedidoEntity> PedidoList()
        {
            using (var db = new TiendaContext())
            {
                return db.Pedido.ToList();
            }
        }

        public void CrearPedido(PedidoEntity oPedido)
        {
            using (var db = new TiendaContext())
            {
                db.Pedido.Add(oPedido);
                db.SaveChanges();
            }
        }

        public void ActualizarPedido(PedidoEntity oPedido)
        {
            using (var db = new TiendaContext())
            {
                db.Pedido.Update(oPedido);
                db.SaveChanges();
            }
        }

    }
}
