﻿using Microsoft.EntityFrameworkCore;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public SwitchContext(DbContextOptions Options) : base(Options)
        {
            
        }

    }
}
