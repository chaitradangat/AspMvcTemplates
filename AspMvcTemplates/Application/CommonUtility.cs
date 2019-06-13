using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcTemplates.Application
{
    public class CommonUtility
    {
        public bool ValidateLoginCredentials(string username,string password,ref string userid)
        {
            if (username == "admin" && password == "admin")
            {
                userid = "1";

                return true;
            }
            else
            {
                return false;
            }
        }



    }
}