using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasker
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        
    }
}
