﻿using System;
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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ADRYDEV;Initial Catalog=DCUFinalProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into CRUD (name, lastName, email, phone) values (@name, @lastName, @email, @phone)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("User Successfully Created");
        }
    }
}
