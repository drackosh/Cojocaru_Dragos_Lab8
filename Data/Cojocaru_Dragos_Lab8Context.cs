using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cojocaru_Dragos_Lab8.Models;

namespace Cojocaru_Dragos_Lab8.Data
{
    public class Cojocaru_Dragos_Lab8Context : DbContext
    {
        public Cojocaru_Dragos_Lab8Context (DbContextOptions<Cojocaru_Dragos_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cojocaru_Dragos_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cojocaru_Dragos_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cojocaru_Dragos_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
