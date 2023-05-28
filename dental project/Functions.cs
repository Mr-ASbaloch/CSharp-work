using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dental_project
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;


        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\OneDrive\\Documents\\DentalCareDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand(ConStr);
            Cmd.Connection = Con;
        }
        public DataTable GetData(String Query);
        {
         dt=new DataTable();
       sda=new SqlDataAdapter(Query, ConStr);
        sda.Fill(dt);
            return DataTable;
            
        }

       
       
    }
}
