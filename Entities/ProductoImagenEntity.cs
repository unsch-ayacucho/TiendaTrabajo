using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductoImagenEntity
    {
        [Key]
        public int ProductoImagenId { get; set; }
        public int ProductoId { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }

        public virtual ProductoEntity Producto { get; set; }

    }
}
