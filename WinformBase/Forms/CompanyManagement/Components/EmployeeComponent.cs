using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinformBase.Forms.CompanyManagement.Components
{
    public partial class EmployeeComponent : UserControl
    {
        private DataGridView dgvEmployees;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
        private TextBox txtSearchEmployee;
        private Label lblSearchEmployee;
        private ComboBox cboDepartmentFilter;
        private Label lblDepartmentFilter;

        public EmployeeComponent()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeComponent()
        {
            this.dgvEmployees = new DataGridView();
            this.btnAddEmployee = new Button();
            this.btnEditEmployee = new Button();
            this.btnDeleteEmployee = new Button();
            this.txtSearchEmployee = new TextBox();
            this.lblSearchEmployee = new Label();
            this.cboDepartmentFilter = new ComboBox();
            this.lblDepartmentFilter = new Label();

            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Location = new Point(10, 15);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new Size(41, 13);
            this.lblSearchEmployee.Text = "Search:";
            this.lblSearchEmployee.TabIndex = 0;

            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new Point(60, 12);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new Size(200, 20);
            this.txtSearchEmployee.TabIndex = 1;

            // 
            // lblDepartmentFilter
            // 
            this.lblDepartmentFilter.AutoSize = true;
            this.lblDepartmentFilter.Location = new Point(280, 15);
            this.lblDepartmentFilter.Name = "lblDepartmentFilter";
            this.lblDepartmentFilter.Size = new Size(62, 13);
            this.lblDepartmentFilter.Text = "Department:";
            this.lblDepartmentFilter.TabIndex = 2;

            // 
            // cboDepartmentFilter
            // 
            this.cboDepartmentFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDepartmentFilter.FormattingEnabled = true;
            this.cboDepartmentFilter.Location = new Point(350, 12);
            this.cboDepartmentFilter.Name = "cboDepartmentFilter";
            this.cboDepartmentFilter.Size = new Size(150, 21);
            this.cboDepartmentFilter.TabIndex = 3;

            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new Point(520, 10);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new Size(75, 23);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = true;

            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new Point(605, 10);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new Size(75, 23);
            this.btnEditEmployee.TabIndex = 5;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;

            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new Point(690, 10);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 6;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;

            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new Point(10, 45);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new Size(760, 400);
            this.dgvEmployees.TabIndex = 7;

            // 
            // EmployeeComponent
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cboDepartmentFilter);
            this.Controls.Add(this.lblDepartmentFilter);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.lblSearchEmployee);
            this.Name = "EmployeeComponent";
            this.Size = new Size(780, 460);
            this.TabIndex = 0;
        }

        private void InitializeEvents()
        {
            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnEditEmployee.Click += BtnEditEmployee_Click;
            btnDeleteEmployee.Click += BtnDeleteEmployee_Click;
            txtSearchEmployee.TextChanged += TxtSearchEmployee_TextChanged;
            cboDepartmentFilter.SelectedIndexChanged += CboDepartmentFilter_SelectedIndexChanged;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            // TODO: Implement Add Employee logic
            MessageBox.Show("Add Employee functionality will be implemented here.");
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                // TODO: Implement Edit Employee logic
                MessageBox.Show("Edit Employee functionality will be implemented here.");
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // TODO: Implement Delete Employee logic
                    MessageBox.Show("Delete Employee functionality will be implemented here.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            // TODO: Implement search functionality
            // Filter employees based on search text
        }

        private void CboDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Implement department filter functionality
            // Filter employees by selected department
        }

        private void DgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // TODO: Implement double-click to edit functionality
                MessageBox.Show("Double-click functionality will be implemented here.");
            }
        }

        public void LoadEmployees()
        {
            // TODO: Load employees from database
            // This method will be called from parent form
        }

        public void LoadDepartments()
        {
            // TODO: Load departments for filter combo box
            // This method will be called from parent form
        }

        public void RefreshData()
        {
            // TODO: Refresh employee data
            LoadEmployees();
        }
    }
}
