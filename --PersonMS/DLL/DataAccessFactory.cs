using DLL.EF.Models;
using DLL.Interfaces;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public  class DataAccessFactory
    {
        public static  IRepo<Person,string> PersonData()
        {
            return new PersonRepo();
        }
    }
}
