using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Menu
    {
        public List<MenuEntity> MenuList()
        {
            using (var db = new TiendaContext())
            {
                return db.Menu.ToList();
            }
        }

        public void CrearMenu(MenuEntity oMenu)
        {
            using (var db = new TiendaContext())
            {
                db.Menu.Add(oMenu);
                db.SaveChanges();
            }
        }

        public void ActualizarMenu(MenuEntity oMenu)
        {
            using (var db = new TiendaContext())
            {
                db.Menu.Update(oMenu);
                db.SaveChanges();
            }
        }

    }
}
