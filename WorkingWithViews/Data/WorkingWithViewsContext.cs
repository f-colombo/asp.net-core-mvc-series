using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkingWithViews.Models;

namespace WorkingWithViews.Data
{
    public class WorkingWithViewsContext : DbContext
    {
        public WorkingWithViewsContext (DbContextOptions<WorkingWithViewsContext> options)
            : base(options)
        {
        }

        public DbSet<WorkingWithViews.Models.Book> Book { get; set; }
    }
}
