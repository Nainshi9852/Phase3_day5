using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assign4.Models;

namespace Assign4.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assign4.Models.Book> Book { get; set; } = default!;
    }
}
