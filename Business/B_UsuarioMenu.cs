using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_UsuarioMenu
    {
        public List<UsuarioMenuEntity> UsuarioMenuList()
        {
            using (var db = new TiendaContext())
            {
                return db.UsuarioMenu.ToList();
            }
        }

        public void CrearUsuarioMenu(UsuarioMenuEntity oUsuarioMenu)
        {
            using (var db = new TiendaContext())
            {
                db.UsuarioMenu.Add(oUsuarioMenu);
                db.SaveChanges();
            }
        }

        public void ActualizarUsuarioMenu(UsuarioMenuEntity oUsuarioMenu)
        {
            using (var db = new TiendaContext())
            {
                db.UsuarioMenu.Update(oUsuarioMenu);
                db.SaveChanges();
            }
        }

    }
}
