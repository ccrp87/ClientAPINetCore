using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Controllers;
using API.Models;

namespace API.Data
{
    public class APINetCoreContext : DbContext
    {
        public APINetCoreContext (DbContextOptions<APINetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<API.Controllers.Cliente> Cliente { get; set; }

        public DbSet<API.Models.Producto> Producto { get; set; }

        public DbSet<API.Models.Tienda> Tienda { get; set; }

        public DbSet<API.Models.Factura> Factura { get; set; }

        public DbSet<API.Models.FacturaDetalle> FacturaDetalle { get; set; }

        public DbSet<API.Models.Usuario> Usuario { get; set; }
    }
}
