using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DCUFinalProject
{
    public partial class ReadUser : Form
    {
        public ReadUser()
        {
            InitializeComponent();
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADRYDEV;Initial Catalog=DCUFinalProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from CRUD where id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
