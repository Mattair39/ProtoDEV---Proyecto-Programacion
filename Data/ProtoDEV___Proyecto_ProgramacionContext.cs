using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProtoDEV___Proyecto_Programacion.Models;

namespace ProtoDEV___Proyecto_Programacion.Data
{
    public class ProtoDEV___Proyecto_ProgramacionContext : IdentityDbContext
    {
        public ProtoDEV___Proyecto_ProgramacionContext (DbContextOptions<ProtoDEV___Proyecto_ProgramacionContext> options)
            : base(options)
        {
        }

        public DbSet<ProtoDEV___Proyecto_Programacion.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<ProtoDEV___Proyecto_Programacion.Models.Producto> Producto { get; set; } = default!;

        public DbSet<ProtoDEV___Proyecto_Programacion.Models.ApplicationUser> ApplicationUsers { get; set; } = default!;
    }
}
