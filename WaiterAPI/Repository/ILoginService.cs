using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.Models;
namespace WaiterAPI.Repository
{
    public interface ILoginService
    {
        Task<User> Login(string usrname, string pword);
    }
}
