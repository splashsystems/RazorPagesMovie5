using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie5.Models;

namespace RazorPagesMovie5.Data
{
    public class RazorPagesMovie5Context : DbContext
    {
        public RazorPagesMovie5Context (DbContextOptions<RazorPagesMovie5Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie5.Models.Movie> Movie { get; set; }
    }
}
