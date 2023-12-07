using DLL.EF.Models;
using DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    internal class PersonRepoVersion2 : Repo , IRepo<Person, string>
    {
       
        public List<Person> Get()
        {
            return null;
        }

        public string Create(Person obj)
        {
            return "Created";
        }
    }
}
