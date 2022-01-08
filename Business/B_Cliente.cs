using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Cliente
    {
        public List<ClienteEntity> ClienteList()
        {
            using (var db = new TiendaContext())
            {
                return db.Cliente.ToList();
            }
        }

        public void CrearCliente(ClienteEntity oCliente)
        {
            using (var db = new TiendaContext())
            {
                db.Cliente.Add(oCliente);
                db.SaveChanges();
            }
        }

        public void ActualizarCliente(ClienteEntity oCliente)
        {
            using (var db = new TiendaContext())
            {
                db.Cliente.Update(oCliente);
                db.SaveChanges();
            }
        }

    }
}
