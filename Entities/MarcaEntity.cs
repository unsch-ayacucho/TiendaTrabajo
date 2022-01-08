﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MarcaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Denominacion { get; set; }

        public virtual ICollection<ProductoEntity> Producto { get; set; }
    }
}
