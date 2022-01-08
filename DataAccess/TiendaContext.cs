using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TiendaContext: DbContext
    {
        public DbSet<ProductoEntity> Producto { get; set; }
        public DbSet<CategoriaEntity> Categoria { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<DireccionEntity> Direccion { get; set; }
        public DbSet<EntradaEntity> Entrada { get; set; }
        public DbSet<EntradaDetalleEntity> EntradaDetalle { get; set; }
        public DbSet<MarcaEntity> Marca { get; set; }
        public DbSet<MenuEntity> Menu { get; set; }
        public DbSet<PedidoEntity> Pedido { get; set; }
        public DbSet<PedidoDetalleEntity> PedidoDetalle { get; set; }
        public DbSet<ProductoImagenEntity> ProductoImagen { get; set; }
        public DbSet<ProveedorEntity> Proveedor { get; set; }
        public DbSet<UsuarioEntity> Usuario { get; set; }
        public DbSet<UsuarioMenuEntity> UsuarioMenu { get; set; }

        //migracion a la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =.; Database = Tienda2; User Id = sa; Password = 1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoriaEntity>().HasData(
                new CategoriaEntity() { Id = 23, Denominacion = "jejejeej" }
            );
        }
    }
}
