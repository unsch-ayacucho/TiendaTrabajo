using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Marca
    {
        public List<MarcaEntity> MarcaList()
        {
            using (var db = new TiendaContext())
            {
                return db.Marca.ToList();
            }
        }

        public void CrearMarca(MarcaEntity oMarca)
        {
            using (var db = new TiendaContext())
            {
                db.Marca.Add(oMarca);
                db.SaveChanges();
            }
        }

        public void ActualizarMarca(MarcaEntity oMarca)
        {
            using (var db = new TiendaContext())
            {
                db.Marca.Update(oMarca);
                db.SaveChanges();
            }
        }

    }
}
