using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntradaEntity
    {
        [Key]

        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }
        public int UsuarioCreacionId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ProveedorEntity Proveedor { get; set; }
        public virtual UsuarioEntity UsuarioCreacion { get; set; }
        public virtual ICollection<EntradaDetalleEntity> EntradaDetalle { get; set; }
    }
}
