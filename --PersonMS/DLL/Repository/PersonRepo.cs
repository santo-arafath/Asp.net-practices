using DLL.EF;
using DLL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using DLL.Repository;
using DLL.Interfaces;

namespace DLL.Repository
{
    internal class PersonRepo : Repo, IRepo<Person, string>
    {
        public string Create(Person obj)
        {
            db.Persons.Add(obj);
            db.SaveChanges();
            return "Created";
        }

        public List<Person> Get()
        {
            var data = db.Persons.ToList();
            return data;
        }
    }
}

