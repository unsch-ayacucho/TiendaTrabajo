using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MenuEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Modulo { get; set; }
        public string Icono { get; set; }
        public bool IndPadre { get; set; }
        public int? Referencia { get; set; }

        public virtual ICollection<UsuarioMenuEntity> UsuarioMenu { get; set; }
    }
}
