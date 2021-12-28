using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class Direccion
    {
        public Direccion()
        {
            InverseCliente = new HashSet<Direccion>();
            Pedido = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Denominacion { get; set; }
        public string Estado { get; set; }
        public int? ClienteId { get; set; }

        public virtual Direccion Cliente { get; set; }
        public virtual ICollection<Direccion> InverseCliente { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
