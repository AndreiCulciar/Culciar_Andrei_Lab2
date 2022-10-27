using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Culciar_Andrei_Lab2.Models;

namespace Culciar_Andrei_Lab2.Data
{
    public class Culciar_Andrei_Lab2Context : DbContext
    {
        public Culciar_Andrei_Lab2Context (DbContextOptions<Culciar_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Culciar_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Culciar_Andrei_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Culciar_Andrei_Lab2.Models.Authors> Authors { get; set; }
    }
}
