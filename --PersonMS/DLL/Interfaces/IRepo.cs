using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    public interface IRepo<CLASS,RET>
    {
        List<CLASS> Get();
        RET Create(CLASS obj);
        
    }
}
