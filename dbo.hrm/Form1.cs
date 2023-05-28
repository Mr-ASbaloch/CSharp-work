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

namespace dbo.hrm
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-10L069L\SQLEXPRESS;Initial Catalog=""employee hrm"";Integrated Security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into emp_hrm (ID,emp_fname,emp_lname,emp_email) values (@ID,@FName,@LName,@Email)", conn);
            cmd.Parameters.AddWithValue("@ID", emp_id.Text);
            cmd.Parameters.AddWithValue("@FName", fname.Text);
            cmd.Parameters.AddWithValue("@LName", lname.Text);
            cmd.Parameters.AddWithValue("@Email", email.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record added successfully");
            conn.Close();
            DisplayData();
          
        }
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from emp_hrm", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            emp_id.Text = "";
            email.Text = "";
       
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (emp_id.Text != "" && email.Text != "" && fname.Text != "" && lname
                .Text != "")
            {
                cmd = new SqlCommand("update emp-hrm set First Name=fname, where Last name=lname ID=emp-id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", emp_id.Text);
                cmd.Parameters.AddWithValue("@FName", fname.Text);
                cmd.Parameters.AddWithValue("@LName", lname.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();      
                DisplayData();
                ClearData();

                

            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            emp_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            fname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
