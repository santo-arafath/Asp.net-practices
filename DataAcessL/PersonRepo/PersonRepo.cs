using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessL.PersonRepo
{
    public class PersonRepo
    {
        public static string GetName(int id)
        {
            return id == 110 ? "Santo" : "User not found";
        }
    }
}
