using ApplicationLApi.EF.Models;
using DataAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL.PersonRepo
{
    public class PersonRepo
    {
        public static List<Person> GetAllPerson()
        {
            var db =new PersonManagementContext();
            var data = db.Persons.ToList();
            return data;
        }
    }
}
