using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    public class SchoolContext : DbContext
    {
        private readonly Microsoft.Extensions.Logging.ILoggerFactory loggerFactory = LoggerFactory.Create(query => query.AddConsole());
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);
           
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
