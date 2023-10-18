using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class libreriaContexto : DbContext
    {
        public libreriaContexto(DbContextOptions<libreriaContexto> options)
        :base(options){ }

        public DbSet<libro> libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<libro>().ToTable("libro");
        }


    }
}
