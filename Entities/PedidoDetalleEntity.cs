using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoDetalleEntity
    {
        [Key]
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public decimal? Precio { get; set; }
        public int Cantidad { get; set; }

        public virtual PedidoEntity Pedido { get; set; }
        public virtual ProductoEntity Producto { get; set; }

    }
}
