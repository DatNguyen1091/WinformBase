using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinformBase.Forms.ProjectManagement
{
    public partial class ProjectManagementForm : Form
    {
        public ProjectManagementForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Form properties
            this.Text = "Project Management";
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
                Text = "📋 Project Management",
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
                Text = "🚀 Project Management Features\n\n" +
                       "• Project Planning & Scheduling\n" +
                       "• Task Management\n" +
                       "• Team Collaboration\n" +
                       "• Progress Tracking\n" +
                       "• Resource Management\n" +
                       "• Timeline Visualization\n\n" +
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
