using DataAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationLApi.EF.Models
{
    public class PersonManagementContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}