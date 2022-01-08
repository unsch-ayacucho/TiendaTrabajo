using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProveedorEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }

    }
}
