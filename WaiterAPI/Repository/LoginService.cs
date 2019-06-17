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
        public async Task<User> Login(string usrname, string pword)
        {
            List<User> u = new List<User>();
            var usrs = await Task.Run(() => u.SingleOrDefault(x => x.username == usrname && x.password == pword));
            db.Users.Where(x => x.username == usrname &&x.password == pword).FirstOrDefault();
            if (usrs == null)
                return null;

            return usrs;

        }
    }
}
