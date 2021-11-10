using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaWebVuelos.Models;

namespace SistemaWebVuelos.Data
{
    public class VueloDbContext:DbContext
    {
       public VueloDbContext() : base("KeyDb") { }
       public DbSet<Vuelo> Vuelos { get; set; }
    }
}