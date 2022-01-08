using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DireccionEntity
    {
        [Key]

        public int Id { get; set; }
        public string Denominacion { get; set; }
        public string Estado { get; set; }
        public int? ClienteId { get; set; }

        public virtual DireccionEntity Cliente { get; set; }
        public virtual ICollection<DireccionEntity> InverseCliente { get; set; }
        public virtual ICollection<PedidoEntity> Pedido { get; set; }
    }
}
