using System;
using System.Windows.Forms;
using StudentApp.Controllers;
using StudentApp.Models;
using StudentApp.Views;

namespace StudentApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            LoginController loginController = new LoginController();

            if (loginController.Login(email, password))
            {
                this.Hide();
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
