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
            bool success = false;
            string[] userInfo=l.getLogin(u);
            if (userInfo != null)
            {
                string hash = userInfo[1];
                success = Crypto.VerifyHashedPassword(hash, p);
            }
            return success;
        }
    }
}
