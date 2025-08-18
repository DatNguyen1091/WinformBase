using System;
using System.Drawing;
using System.Windows.Forms;
using WinformBase.Forms.CompanyManagement.Components;

namespace WinformBase.Forms.CompanyManagement
{
    public partial class CompanyManagementForm : Form
    {
        private TabControl tabControl;
        private TabPage tabDepartments;
        private TabPage tabEmployees;
        private TabPage tabPositions;

        public CompanyManagementForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl = new TabControl();
            this.tabDepartments = new TabPage();
            this.tabEmployees = new TabPage();
            this.tabPositions = new TabPage();

            // TabControl
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.BackColor = Color.FromArgb(30, 30, 30);
            this.tabControl.ForeColor = Color.White;

            // Departments Tab
            this.tabDepartments.Text = "🏢 Departments";
            this.tabDepartments.BackColor = Color.FromArgb(30, 30, 30);
            this.tabDepartments.UseVisualStyleBackColor = false;

            // Employees Tab
            this.tabEmployees.Text = "👥 Employees";
            this.tabEmployees.BackColor = Color.FromArgb(30, 30, 30);
            this.tabEmployees.UseVisualStyleBackColor = false;

            // Positions Tab
            this.tabPositions.Text = "💼 Positions";
            this.tabPositions.BackColor = Color.FromArgb(30, 30, 30);
            this.tabPositions.UseVisualStyleBackColor = false;

            // Add tabs to control
            this.tabControl.TabPages.Add(this.tabDepartments);
            this.tabControl.TabPages.Add(this.tabEmployees);
            this.tabControl.TabPages.Add(this.tabPositions);

            // Add controls to form
            this.Controls.Add(this.tabControl);

            // Initialize Department tab content
            InitializeDepartmentTab();
            InitializeEmployeeTab();
            InitializePositionTab();
        }

        private void InitializeDepartmentTab()
        {
            var departmentComponent = new DepartmentComponent();
            departmentComponent.Dock = DockStyle.Fill;
            tabDepartments.Controls.Add(departmentComponent);
        }

        private void InitializeEmployeeTab()
        {
            var employeeComponent = new EmployeeComponent();
            employeeComponent.Dock = DockStyle.Fill;
            tabEmployees.Controls.Add(employeeComponent);
        }

        private void InitializePositionTab()
        {
            var positionComponent = new PositionComponent();
            positionComponent.Dock = DockStyle.Fill;
            tabPositions.Controls.Add(positionComponent);
        }
    }
}
