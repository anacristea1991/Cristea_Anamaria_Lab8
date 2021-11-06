using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cristea_Anamaria_Lab8.Models;

namespace Cristea_Anamaria_Lab8.Data
{
    public class Cristea_Anamaria_Lab8Context : DbContext
    {
        public Cristea_Anamaria_Lab8Context (DbContextOptions<Cristea_Anamaria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cristea_Anamaria_Lab8.Models.Book> Book { get; set; }
    }
}
