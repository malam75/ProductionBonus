using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace MainMenu
{
    class general
    {
        public static String strLoc;
        public static string conStr= ConfigurationManager.ConnectionStrings["CNN"].ConnectionString;

    }
    
   
}
