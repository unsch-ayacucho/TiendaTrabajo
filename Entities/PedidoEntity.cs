using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoEntity
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int? DireccionId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public string Estado { get; set; }

        public virtual ClienteEntity Cliente { get; set; }
        public virtual DireccionEntity Direccion { get; set; }
        public virtual ICollection<PedidoDetalleEntity> PedidoDetalle { get; set; }

    }
}
