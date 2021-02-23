using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Context
{
    class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usarios { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {

        }
    }
}
