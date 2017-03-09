using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petrlitvinov.Models
{
    public class PhotoContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public PhotoContext(DbContextOptions<PhotoContext> options)
            : base(options)
        {
        }
    }
}
