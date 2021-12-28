using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dominio.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Tienda.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class ProductoController : Controller
    {
        private readonly TiendaContext _context;
        private readonly IHostingEnvironment _environment;

        public ProductoController(TiendaContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Administrador/Productowher
        public async Task<IActionResult> Index()
        {
            var tiendaContext = _context.Producto.Include(p => p.Categoria).Include(p => p.Marca);
            return View(await tiendaContext.ToListAsync());
        }
        public async Task<IActionResult> Imagen(int id)
        {
            ViewBag.ProductoId = id;
            var imagenes = await _context.ProductoImagen
                                    .Where(x => x.ProductoId == id).ToListAsync();
            return View(imagenes);
        }

        [HttpPost]
        public async Task<ActionResult> SubirImagen(IFormFile imagen, int pProductoId)
        {
            if (imagen != null && imagen.Length > 0)
            {
                var rutaBase = Path.Combine(_environment.WebRootPath, "imagen\\");
                if (!Directory.Exists(rutaBase))
                    Directory.CreateDirectory(rutaBase);

                var rutaImagen = Path.Combine(_environment.WebRootPath, "imagen\\", pProductoId.ToString() + "\\");
                if (!Directory.Exists(rutaImagen))
                    Directory.CreateDirectory(rutaImagen);

                string archivo = Guid.NewGuid() + Path.GetExtension(imagen.FileName).ToLower();
                string relativePath = rutaImagen + archivo;
                using (var stream = new FileStream(relativePath, FileMode.Create))
                {
                    imagen.CopyTo(stream);
                }

                _context.ProductoImagen.Add(new ProductoImagen { ProductoId = pProductoId, Imagen = archivo });
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Imagen", new { id = pProductoId });
        }
        [HttpPost]
        public async Task<ActionResult> EliminarImagen(int pProductoImagenId)
        {
            var productoImagen = await _context.ProductoImagen.FindAsync(pProductoImagenId);

            var ruta = Path.Combine(_environment.WebRootPath, "imagen\\", productoImagen.ProductoId.ToString() + "\\", productoImagen.Imagen);
            if (System.IO.File.Exists(ruta))
                System.IO.File.Delete(ruta);

            _context.ProductoImagen.Remove(productoImagen);
            await _context.SaveChangesAsync();
            return Json(true);
        }



        // GET: Administrador/Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Administrador/Producto/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion");
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion");
            return View();
        }

        // POST: Administrador/Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Denominacion,Descripcion,Costo,Precio,Existencias,MarcaId,CategoriaId,Estado")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion", producto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion", producto.MarcaId);
            return View(producto);
        }

        // GET: Administrador/Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion", producto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion", producto.MarcaId);
            return View(producto);
        }

        // POST: Administrador/Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Denominacion,Descripcion,Costo,Precio,Existencias,MarcaId,CategoriaId,Estado")] Producto producto)
        {
            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Denominacion", producto.CategoriaId);
            ViewData["MarcaId"] = new SelectList(_context.Marca, "Id", "Denominacion", producto.MarcaId);
            return View(producto);
        }

        // GET: Administrador/Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Administrador/Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
