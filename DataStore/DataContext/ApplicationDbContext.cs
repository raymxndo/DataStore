using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataStore.Models;

namespace DataStore.DataContext
{
    class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DRPHDBTLT23\SQLEXPRESS;Initial Catalog=SewSew;Integrated Security=True");
        }

        public DbSet<Person> Person { get; set; }
    }
}
