﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Data
{
    public class DBLineaAereaContext : DbContext
    {
        public DBLineaAereaContext() : base("KeyDB") { }

        public DbSet<Avion> Aviones { get; set; }
        public DbSet<LineaAerea> LineasAereas { get; set; }
    }
}