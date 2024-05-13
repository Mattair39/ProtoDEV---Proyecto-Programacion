using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProtoDEV___Proyecto_Programacion.Data;

namespace ProtoDEV___Proyecto_Programacion.Controllers
{
    public class TiendasController : Controller
    {
        private readonly ProtoDEV___Proyecto_ProgramacionContext _context;

        public TiendasController(ProtoDEV___Proyecto_ProgramacionContext context)
        {
            _context = context;
        }
        // GET: HomeController1
        public async Task<IActionResult> Index()
        {
            var protoDEV___Proyecto_ProgramacionContext = _context.Producto.Include(p => p.Categoria);
            return View(await protoDEV___Proyecto_ProgramacionContext.ToListAsync());
        }

        // GET: HomeController1/Details/5
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FirstOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto); // Pasa un solo objeto Producto
        }
    }
}
