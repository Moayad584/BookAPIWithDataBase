using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DBaseContext : DbContext
    {
        public DBaseContext( DbContextOptions<DBaseContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
