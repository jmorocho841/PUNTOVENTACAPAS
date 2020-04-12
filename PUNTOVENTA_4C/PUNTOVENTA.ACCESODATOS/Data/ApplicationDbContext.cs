using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PUNTOVENTA.MODELOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUNTOVENTA.ACCESODATOS.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<User> Users { get; set; }
    }
}
