using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Clinic_management_system
{
    internal class MyPatient
    {
        public void AddPatient(string query)
        {
            ConnectionString MyConnection = new ConnectionString();
            Sqlconnection con =  MyConnection.GetConn();
            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Connection = con;
            con.Open();
            cmd.ComandText = query; 
            cmd.ExecteNonQuery();
            con.Close();

        }

        internal DataSet ShowPatient(string query)
        {
            throw new NotImplementedException();
        }
    }
}
