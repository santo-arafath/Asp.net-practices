using DLL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.EF
{
    public class PersonMSContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
