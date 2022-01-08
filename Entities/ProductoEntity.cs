using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Denominacion { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }
        public string Estado { get; set; }

        public virtual CategoriaEntity Categoria { get; set; }

        //public virtual ICollection<EntradaEntity> EntradaDetalle { get; set; }
        public virtual ICollection<PedidoDetalleEntity> PedidoDetalle { get; set; }
        public virtual ICollection<ProductoImagenEntity> ProductoImagen { get; set; }
    }
}
