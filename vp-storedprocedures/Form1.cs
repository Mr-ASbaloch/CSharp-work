using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_storedprocedures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\OneDrive\\Documents\\SpDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd=new SqlCommand("exec insertEmp_sp '"+ int.Parse(textBox1.Text) +"','"+ textBox2.Text +"','"+textBox3.Text+"' ",con);
           cmd.ExecuteNonQuery();
           
            MessageBox.Show("successfully added");
            con.Close();
            loadrecords();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadrecords();
        }
        void loadrecords()
        {
            SqlCommand cmd = new SqlCommand("exec Record_sp  ", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("exec updateEmp_sp '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + textBox3.Text + "' ", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("successfully updated");
            con.Close();
            loadrecords();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("exec delEmp_sp '" + int.Parse(textBox1.Text) + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully");
            loadrecords();

        }
    }
}
