using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practical_26.Models;

namespace Practical_26.Data
{
    public class Practical_26Context : DbContext
    {
        public Practical_26Context (DbContextOptions<Practical_26Context> options)
            : base(options)
        {
        }

        public DbSet<Practical_26.Models.User>? User { get; set; }
    }
}
