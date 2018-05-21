using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Web.Helpers;

namespace login
{
    class LoginHandler
    {
        static LoginData l=new LoginData();
        public static bool processLogin(string u, string p)
        {
            string [] userInfo=l.getLogin(u);
            string hash = userInfo[1];
            bool success = Crypto.VerifyHashedPassword(hash, p);
            return success;
        }
    }
}
