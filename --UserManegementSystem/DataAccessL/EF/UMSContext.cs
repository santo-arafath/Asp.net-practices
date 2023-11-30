using DataAccessL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.EF
{
    public class UMSContext:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
