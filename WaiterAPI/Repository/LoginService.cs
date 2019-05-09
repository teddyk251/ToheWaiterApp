using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaiterAPI.DBContext;
using WaiterAPI.Models;
namespace WaiterAPI.Repository
{
    public class LoginService : ILoginService
    {
        WaiterContext db = new WaiterContext();
        public LoginService(WaiterContext db)
        {
            this.db = db;
        }
        public bool login(string usrname, string pword)
        {
            var usrs = db.Users.Where(x => x.username == usrname &&
                                           x.password == pword)
                                           .FirstOrDefault();
            if (usrs == null)
            {
                return false;
            }

            return true;

        }
    }
}
