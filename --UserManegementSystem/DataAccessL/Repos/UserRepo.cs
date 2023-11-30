using DataAccessL.EF;
using DataAccessL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessL.Repos
{
    public class UserRepo
    {
        public static List<User> getAll()
        {
            var db = new UMSContext();
            var data = db.Users.ToList();
            return data;
        }

        public static User getUserById(int id)
        {
            var db = new UMSContext();
            var data = db.Users.Find(id);
            return data;
        }

        public static string CreateUser(User us)
        {
            var db = new UMSContext();
            db.Users.Add(us);
            db.SaveChanges();

            return "Created";
           
        }

        public static string DeleteUser(int id)
        {
            var db = new UMSContext();
            var ex = db.Users.Find(id);
            if (ex != null)
            {
                db.Users.Remove(ex);
                db.SaveChanges();
                return "Delete";
            }
          
            return "User Not found";

        }


        public static string UpdateUser(User us,int id)
        {
            var db = new UMSContext();
            var ex = db.Users.Find(id);
            if (ex != null)
            {
                ex.Name = us.Name;
                ex.Address = us.Address;
                db.SaveChanges();
                return "User Updated";
            }

            return "User Not found";

        }
    }
}
