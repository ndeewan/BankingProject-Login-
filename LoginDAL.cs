using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BankingLib
{
    public class LoginDAL
    {
        
        public bool VerifyData(Login lg)
        {
            bool loginStatus = false;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Banking"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from login where CRN ='"+lg.CRN+"' and Password='"+lg.Password+"'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                cn.Close();
                loginStatus = true;
            }
            else
            {
                cn.Close();
                loginStatus = false;
            }

            return loginStatus;
        }

    }
}
