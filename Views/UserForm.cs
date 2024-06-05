using StudentApp.Models;
using System.Net;
using StudentApp.Controllers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudentApp.Views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            User user = await userController.GetUserById(1);

            if (user != null)
            {
                usernameLabel.Text = user.Name;
                emailLabel.Text = user.Email;
                dateOfBirthLabel.Text = user.DateOfBirth;
                userIdLabel.Text = user.UserId;
                majorLabel.Text = user.Major;
                await LoadUserImageAsync(user.ImgUrl);
            }
            else
            {
                MessageBox.Show("User not found");
                Close();
            }
        }

        private async Task LoadUserImageAsync(string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);

                    if (pictureBox.InvokeRequired)
                    {
                        pictureBox.Invoke(new Action(() =>
                        {
                            Image image = Image.FromStream(new MemoryStream(imageBytes));
                            pictureBox.Image = image;
                        }));
                    }
                    else
                    {
                        Image image = Image.FromStream(new MemoryStream(imageBytes));
                        pictureBox.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle image loading errors gracefully
                Console.WriteLine($"Error loading image: {ex.Message}");
                pictureBox.Image = null; // Or set a default image
            }
        }

        private void navigateResultsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }
    }
}
