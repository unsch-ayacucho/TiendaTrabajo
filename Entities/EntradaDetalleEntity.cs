using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntradaDetalleEntity
    {
        [Key]
        public int Id { get; set; }
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }
        public decimal? Costo { get; set; }
        public int Cantidad { get; set; }
        public string Lote { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        public virtual EntradaEntity Entrada { get; set; }
        public virtual ProductoEntity Producto { get; set; }
    }
}
