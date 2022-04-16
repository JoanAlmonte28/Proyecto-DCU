namespace DCUFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void btnReadUser_Click(object sender, EventArgs e)
        {
            ReadUser readUser = new ReadUser();
            readUser.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ShowDialog();
        }
    }
}