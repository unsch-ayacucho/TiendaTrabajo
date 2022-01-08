using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Entrada
    {
        public List<EntradaEntity> EntradaList()
        {
            using (var db = new TiendaContext())
            {
                return db.Entrada.ToList();
            }
        }

        public void CrearEntrada(EntradaEntity oEntrada)
        {
            using (var db = new TiendaContext())
            {
                db.Entrada.Add(oEntrada);
                db.SaveChanges();
            }
        }

        public void ActualizarEntrada(EntradaEntity oEntrada)
        {
            using (var db = new TiendaContext())
            {
                db.Entrada.Update(oEntrada);
                db.SaveChanges();
            }
        }

    }
}
