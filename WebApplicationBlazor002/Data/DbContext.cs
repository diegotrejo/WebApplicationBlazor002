using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationBlazor002.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; } = default!;
        public DbSet<Proveedor> Proveedor { get; set; } = default;
    }
