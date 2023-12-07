using DLL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    internal class Repo
    {
        protected PersonMSContext db;

        protected Repo()
        {
            db = new PersonMSContext();
        }
    }
}
