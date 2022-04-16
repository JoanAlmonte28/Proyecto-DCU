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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADRYDEV;Initial Catalog=DCUFinalProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update CRUD set name = @name, lastName = @lastName, email = @email, phone = @phone where id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Successfully Updated");
        }
    }
}
