namespace StudentApp.Views
{
    partial class UserForm
    {
        private PictureBox pictureBox;
        private Label usernameDescLabel;
        private Label emailDescLabel;
        private Label dateOfBirthDescLabel;
        private Label majorDescLabel;
        private Label userIdDescLabel;
        private Label usernameLabel;
        private Label emailLabel;
        private Label dateOfBirthLabel;
        private Label majorLabel;
        private Label userIdLabel;
        // SIDEBAR
        private Panel sidebarPanel;
        private Button navigateStudentsButton;
        private Button navigateCoursesButton;
        private Button navigateResultsButton;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            sidebarPanel = new Panel();
            navigateStudentsButton = new Button();
            navigateCoursesButton = new Button();
            navigateResultsButton = new Button();
            pictureBox = new PictureBox();
            usernameDescLabel = new Label();
            emailDescLabel = new Label();
            dateOfBirthDescLabel = new Label();
            majorDescLabel = new Label();
            userIdDescLabel = new Label();
            usernameLabel = new Label();
            emailLabel = new Label();
            dateOfBirthLabel = new Label();
            majorLabel = new Label();
            userIdLabel = new Label();
            bindingSource1 = new BindingSource(components);
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = SystemColors.ControlLight;
            sidebarPanel.Controls.Add(navigateStudentsButton);
            sidebarPanel.Controls.Add(navigateCoursesButton);
            sidebarPanel.Controls.Add(navigateResultsButton);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(81, 460);
            sidebarPanel.TabIndex = 0;
            // 
            // navigateStudentsButton
            // 
            navigateStudentsButton.Dock = DockStyle.Top;
            navigateStudentsButton.Location = new Point(0, 100);
            navigateStudentsButton.Name = "navigateStudentsButton";
            navigateStudentsButton.Size = new Size(81, 50);
            navigateStudentsButton.TabIndex = 0;
            navigateStudentsButton.Text = "Students";
            // 
            // navigateCoursesButton
            // 
            navigateCoursesButton.Dock = DockStyle.Top;
            navigateCoursesButton.Location = new Point(0, 50);
            navigateCoursesButton.Name = "navigateCoursesButton";
            navigateCoursesButton.Size = new Size(81, 50);
            navigateCoursesButton.TabIndex = 1;
            navigateCoursesButton.Text = "Courses";
            // 
            // navigateResultsButton
            // 
            navigateResultsButton.Dock = DockStyle.Top;
            navigateResultsButton.Location = new Point(0, 0);
            navigateResultsButton.Name = "navigateResultsButton";
            navigateResultsButton.Size = new Size(81, 50);
            navigateResultsButton.TabIndex = 2;
            navigateResultsButton.Text = "HOME";
            navigateResultsButton.Click += navigateResultsButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(105, 50);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(175, 173);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // usernameDescLabel
            // 
            usernameDescLabel.Location = new Point(106, 256);
            usernameDescLabel.Margin = new Padding(4, 0, 4, 0);
            usernameDescLabel.Name = "usernameDescLabel";
            usernameDescLabel.Size = new Size(117, 23);
            usernameDescLabel.TabIndex = 1;
            usernameDescLabel.Text = "Username:";
            // 
            // emailDescLabel
            // 
            emailDescLabel.Location = new Point(106, 290);
            emailDescLabel.Margin = new Padding(4, 0, 4, 0);
            emailDescLabel.Name = "emailDescLabel";
            emailDescLabel.Size = new Size(117, 23);
            emailDescLabel.TabIndex = 3;
            emailDescLabel.Text = "Email:";
            // 
            // dateOfBirthDescLabel
            // 
            dateOfBirthDescLabel.Location = new Point(106, 325);
            dateOfBirthDescLabel.Margin = new Padding(4, 0, 4, 0);
            dateOfBirthDescLabel.Name = "dateOfBirthDescLabel";
            dateOfBirthDescLabel.Size = new Size(117, 23);
            dateOfBirthDescLabel.TabIndex = 5;
            dateOfBirthDescLabel.Text = "Date of Birth:";
            // 
            // majorDescLabel
            // 
            majorDescLabel.Location = new Point(106, 360);
            majorDescLabel.Margin = new Padding(4, 0, 4, 0);
            majorDescLabel.Name = "majorDescLabel";
            majorDescLabel.Size = new Size(117, 23);
            majorDescLabel.TabIndex = 7;
            majorDescLabel.Text = "Major:";
            // 
            // userIdDescLabel
            // 
            userIdDescLabel.Location = new Point(106, 394);
            userIdDescLabel.Margin = new Padding(4, 0, 4, 0);
            userIdDescLabel.Name = "userIdDescLabel";
            userIdDescLabel.Size = new Size(117, 23);
            userIdDescLabel.TabIndex = 9;
            userIdDescLabel.Text = "User ID:";
            // 
            // usernameLabel
            // 
            usernameLabel.BackColor = SystemColors.HighlightText;
            usernameLabel.Location = new Point(246, 256);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(233, 23);
            usernameLabel.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.BackColor = SystemColors.ControlLightLight;
            emailLabel.Location = new Point(246, 290);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(233, 23);
            emailLabel.TabIndex = 4;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.BackColor = SystemColors.ControlLightLight;
            dateOfBirthLabel.Location = new Point(246, 325);
            dateOfBirthLabel.Margin = new Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(233, 23);
            dateOfBirthLabel.TabIndex = 6;
            // 
            // majorLabel
            // 
            majorLabel.BackColor = SystemColors.ControlLightLight;
            majorLabel.Location = new Point(246, 360);
            majorLabel.Margin = new Padding(4, 0, 4, 0);
            majorLabel.Name = "majorLabel";
            majorLabel.Size = new Size(233, 23);
            majorLabel.TabIndex = 8;
            // 
            // userIdLabel
            // 
            userIdLabel.BackColor = SystemColors.ControlLightLight;
            userIdLabel.Location = new Point(246, 394);
            userIdLabel.Margin = new Padding(4, 0, 4, 0);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new Size(233, 23);
            userIdLabel.TabIndex = 10;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(sidebarPanel);
            Controls.Add(pictureBox);
            Controls.Add(usernameDescLabel);
            Controls.Add(usernameLabel);
            Controls.Add(emailDescLabel);
            Controls.Add(emailLabel);
            Controls.Add(dateOfBirthDescLabel);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(majorDescLabel);
            Controls.Add(majorLabel);
            Controls.Add(userIdDescLabel);
            Controls.Add(userIdLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserForm";
            Text = "User Profile";
            Load += UserForm_Load;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
    }
}
