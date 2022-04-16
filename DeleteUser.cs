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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADRYDEV;Initial Catalog=DCUFinalProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete CRUD where id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Successfully Deleted");
        }
    }
}
