using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourse.DAL
{
    public class Connexion
    {
        public static class Connection
        {
            public static string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\FRED PEUGH'S\Documents\DataBase.mdf"";Integrated Security=True;Connect Timeout=30";
            public static SqlConnection con = new SqlConnection(connect);
            public static SqlCommand cmd;
        }
    }
}
