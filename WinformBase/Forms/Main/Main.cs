using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBase.Forms.CompanyManagement;
using WinformBase.Forms.ProjectManagement;
using WinformBase.Forms.UserManagement;

namespace WinformBase
{
    public partial class Main : Form
    {
        private Form currentForm = null;

        public Main()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Set initial state
            lblCurrentForm.Text = "Welcome to WinformBase";
            
            // Set button styles
            SetButtonStyle(btnCompanyManagement, false);
            SetButtonStyle(btnProjectManagement, false);
            SetButtonStyle(btnUserManagement, false);
        }

        private void SetButtonStyle(Button button, bool isActive)
        {
            if (isActive)
            {
                button.BackColor = Color.FromArgb(0, 122, 204);
                button.ForeColor = Color.White;
            }
            else
            {
                button.BackColor = Color.FromArgb(45, 45, 48);
                button.ForeColor = Color.White;
            }
        }

        private void btnCompanyManagement_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnCompanyManagement, true);
            SetButtonStyle(btnProjectManagement, false);
            SetButtonStyle(btnUserManagement, false);
            
            lblCurrentForm.Text = "🏢 Company Management";
            ShowCompanyManagementForm();
        }

        private void btnProjectManagement_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnCompanyManagement, false);
            SetButtonStyle(btnProjectManagement, true);
            SetButtonStyle(btnUserManagement, false);
            
            lblCurrentForm.Text = "📋 Project Management";
            ShowProjectManagementForm();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            SetButtonStyle(btnCompanyManagement, false);
            SetButtonStyle(btnProjectManagement, false);
            SetButtonStyle(btnUserManagement, true);
            
            lblCurrentForm.Text = "👥 User Management";
            ShowUserManagementForm();
        }

        private void ShowCompanyManagementForm()
        {
            // Clear current content
            panelContent.Controls.Clear();

            // Create Company Management form
            var companyForm = new CompanyManagementForm();
            companyForm.TopLevel = false;
            companyForm.FormBorderStyle = FormBorderStyle.None;
            companyForm.Dock = DockStyle.Fill;
            companyForm.BackColor = panelContent.BackColor;

            panelContent.Controls.Add(companyForm);
            companyForm.Show();
            currentForm = companyForm;
        }

        private void ShowProjectManagementForm()
        {
            // Clear current content
            panelContent.Controls.Clear();

            // Create Project Management form
            var projectForm = new ProjectManagementForm();
            projectForm.TopLevel = false;
            projectForm.FormBorderStyle = FormBorderStyle.None;
            projectForm.Dock = DockStyle.Fill;
            projectForm.BackColor = panelContent.BackColor;

            panelContent.Controls.Add(projectForm);
            projectForm.Show();
            currentForm = projectForm;
        }

        private void ShowUserManagementForm()
        {
            // Clear current content
            panelContent.Controls.Clear();

            // Create User Management form
            var userForm = new UserManagementForm();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            userForm.BackColor = panelContent.BackColor;

            panelContent.Controls.Add(userForm);
            userForm.Show();
            currentForm = userForm;
        }
    }
}
