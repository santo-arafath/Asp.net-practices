using DLL.EF;
using DLL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class PersonRepo
    {

        public static List<Person> GetAll()
        {

            var db = new PersonMSContext();
                var data = db.Persons.ToList();
                return data;
                    
            
        }

        public static String Create(Person Data)
        {

            var db = new PersonMSContext();

            var data = db.Persons.Add(Data);

            db.SaveChanges();
            return "Created";


        }
    }
}
