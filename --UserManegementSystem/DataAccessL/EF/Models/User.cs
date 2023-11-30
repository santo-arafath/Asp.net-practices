using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.EF.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
