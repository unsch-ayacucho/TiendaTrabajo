using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsuarioMenuEntity
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int MenuId { get; set; }

        public virtual MenuEntity Menu { get; set; }
        public virtual UsuarioEntity Usuario { get; set; }
    }
}
