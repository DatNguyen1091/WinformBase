using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinformBase.Forms.UserManagement
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form properties
            this.Text = "User Management";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(30, 30, 30);

            // Main panel
            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            // Header
            var lblHeader = new Label
            {
                Text = "👥 User Management",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 80
            };

            // Content area
            var contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            // Coming soon message
            var lblComingSoon = new Label
            {
                Text = "🔐 User Management Features\n\n" +
                       "• User Authentication & Authorization\n" +
                       "• Role-Based Access Control\n" +
                       "• User Profile Management\n" +
                       "• Password Management\n" +
                       "• User Activity Logging\n" +
                       "• Security Settings\n\n" +
                       "This module is under development...",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.LightGray,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            // Add controls
            contentPanel.Controls.Add(lblComingSoon);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(lblHeader);

            this.Controls.Add(mainPanel);
        }
    }
}
