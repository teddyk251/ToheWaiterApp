using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaiterAPI.Repository
{
    public interface ILoginService
    {
        bool login(string usrname, string pword);
    }
}
