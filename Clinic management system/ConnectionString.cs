using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clinic_management_system
{
    internal class ConnectionString
    {
        public static Sqlconnection GetCon()
        {
            Sqlconnection Con = new Sqlconnection();
           Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\OneDrive\Documents\DentalDb.mdf;Integrated Security=True;Connect Timeout=30";
            return Con;
        }

        internal Sqlconnection GetConn()
        {
            throw new NotImplementedException();
        }
    }
}
