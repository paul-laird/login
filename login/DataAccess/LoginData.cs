using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    class LoginData:DAO
    {
        public void addLogin(string u, string p) { }


        public string[] getLogin(string u) {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.UserLogin "+ //, openConnection());// +
                "WHERE username=@user;", openConnection());
            cmd.Parameters.AddWithValue("@user", u);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string[] s1 = new string[2];
                s1[0] = "" + rdr[0];
                s1[1] = "" + rdr[1];
                return s1;
            }

            return null;
        }
    }
}
