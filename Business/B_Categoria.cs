using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Categoria
    {
        public List<CategoriaEntity> CategoriaList()
        {
            using (var db = new TiendaContext())
            {
                return db.Categoria.ToList();
            }
        }

        public void CrearCategoria(CategoriaEntity oCategoria)
        {
            using (var db = new TiendaContext())
            {
                db.Categoria.Add(oCategoria);
                db.SaveChanges();
            }
        }

        public void ActualizarCategoria(CategoriaEntity oCategoria)
        {
            using(var db = new TiendaContext())
            {
                db.Categoria.Update(oCategoria);
                db.SaveChanges();
            }
        }

    }
}
