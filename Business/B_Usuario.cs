using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Usuario
    {
        public List<UsuarioEntity> UsuarioList()
        {
            using (var db = new TiendaContext())
            {
                return db.Usuario.ToList();
            }
        }

        public void CrearUsuario(UsuarioEntity oUsuario)
        {
            using (var db = new TiendaContext())
            {
                db.Usuario.Add(oUsuario);
                db.SaveChanges();
            }
        }

        public void ActualizarUsuario(UsuarioEntity oUsuario)
        {
            using (var db = new TiendaContext())
            {
                db.Usuario.Update(oUsuario);
                db.SaveChanges();
            }
        }

    }
}
