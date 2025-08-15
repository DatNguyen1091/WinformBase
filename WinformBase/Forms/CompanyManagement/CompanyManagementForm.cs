using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Data;
using BusinessLogic.Services;
using BusinessLogic.Dtos.Responses.Department;
using BusinessLogic.Wrapper;

namespace WinformBase.Forms.CompanyManagement
{
    public partial class CompanyManagementForm : Form
    {
        private TabControl tabControl;
        private TabPage tabDepartments;
        private TabPage tabEmployees;
        private TabPage tabPositions;

        // Pagination controls
        private DataGridView dgvDepartments;
        private Label lblPageInfo;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
        private ComboBox cmbPageSize;
        private Button btnRefresh;

        // Pagination variables
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalPages = 0;
        private int totalRecords = 0;
        private string searchKeyword = "";

        // Service
        private readonly DepartmentService _departmentService;

        public CompanyManagementForm()
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            LoadDepartments();
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
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            // Header Panel
            var headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(37, 37, 38),
                Padding = new Padding(20)
            };

            var lblHeader = new Label
            {
                Text = "🏢 Department Management",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(0, 0),
                Size = new Size(400, 40),
                TextAlign = ContentAlignment.MiddleLeft
            };

            headerPanel.Controls.Add(lblHeader);

            // Search Panel
            var searchPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(30, 30, 30),
                Padding = new Padding(20, 10, 20, 10)
            };

            var lblSearch = new Label
            {
                Text = "Search:",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(0, 15),
                Size = new Size(60, 20)
            };

            txtSearch = new TextBox
            {
                Location = new Point(70, 12),
                Size = new Size(250, 25),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            btnSearch = new Button
            {
                Text = "🔍 Search",
                Location = new Point(330, 12),
                Size = new Size(80, 25),
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSearch.Click += BtnSearch_Click;

            btnClearSearch = new Button
            {
                Text = "❌ Clear",
                Location = new Point(420, 12),
                Size = new Size(80, 25),
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnClearSearch.Click += BtnClearSearch_Click;

            var lblPageSize = new Label
            {
                Text = "Page Size:",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(520, 15),
                Size = new Size(70, 20)
            };

            cmbPageSize = new ComboBox
            {
                Location = new Point(600, 12),
                Size = new Size(80, 25),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbPageSize.Items.AddRange(new object[] { 10, 20, 50, 100 });
            cmbPageSize.SelectedItem = 20;
            cmbPageSize.SelectedIndexChanged += CmbPageSize_SelectedIndexChanged;

            searchPanel.Controls.AddRange(new Control[] { lblSearch, txtSearch, btnSearch, btnClearSearch, lblPageSize, cmbPageSize });

            // Toolbar Panel
            var toolbarPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(30, 30, 30),
                Padding = new Padding(20, 10, 20, 10)
            };

            var btnAdd = new Button
            {
                Text = "➕ Add Department",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, 10),
                Size = new Size(150, 35)
            };
            btnAdd.Click += BtnAddDepartment_Click;

            btnRefresh = new Button
            {
                Text = "🔄 Refresh",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(170, 10),
                Size = new Size(120, 35)
            };
            btnRefresh.Click += BtnRefresh_Click;

            toolbarPanel.Controls.AddRange(new Control[] { btnAdd, btnRefresh });

            // DataGridView
            dgvDepartments = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.White,
                GridColor = Color.FromArgb(63, 63, 70),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false,
                EnableHeadersVisualStyles = false,
                BackgroundColor = Color.FromArgb(45, 45, 48)
            };

            // Style the DataGridView
            dgvDepartments.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvDepartments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvDepartments.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDepartments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvDepartments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDepartments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Add columns
            dgvDepartments.Columns.Add("Id", "ID");
            dgvDepartments.Columns.Add("DeptName", "Department Name");
            dgvDepartments.Columns.Add("Description", "Description");
            dgvDepartments.Columns.Add("CreatedBy", "Created By");
            dgvDepartments.Columns.Add("CreatedOn", "Created On");

            // Pagination Panel
            var paginationPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.FromArgb(37, 37, 38),
                Padding = new Padding(20, 10, 20, 10)
            };

            btnPrevious = new Button
            {
                Text = "◀ Previous",
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, 10),
                Size = new Size(100, 30),
                Enabled = false
            };
            btnPrevious.Click += BtnPrevious_Click;

            lblPageInfo = new Label
            {
                Text = "Page 1 of 1",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(120, 15),
                Size = new Size(200, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnNext = new Button
            {
                Text = "Next ▶",
                Font = new Font("Segoe UI", 9),
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(340, 10),
                Size = new Size(100, 30),
                Enabled = false
            };
            btnNext.Click += BtnNext_Click;

            paginationPanel.Controls.AddRange(new Control[] { btnPrevious, lblPageInfo, btnNext });

            // Add all panels to main panel
            panel.Controls.Add(dgvDepartments);
            panel.Controls.Add(paginationPanel);
            panel.Controls.Add(toolbarPanel);
            panel.Controls.Add(searchPanel);
            panel.Controls.Add(headerPanel);

            this.tabDepartments.Controls.Add(panel);
        }

        private void InitializeEmployeeTab()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            var lblHeader = new Label
            {
                Text = "👥 Employee Management",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                Size = new Size(400, 40)
            };

            var lblComingSoon = new Label
            {
                Text = "👥 Employee management features coming soon...\n\n" +
                       "• Employee Information Management\n" +
                       "• Department Assignment\n" +
                       "• Position Management\n" +
                       "• Salary & Benefits\n" +
                       "• Performance Tracking",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.LightGray,
                Location = new Point(20, 80),
                Size = new Size(600, 200)
            };

            panel.Controls.Add(lblHeader);
            panel.Controls.Add(lblComingSoon);
            this.tabEmployees.Controls.Add(panel);
        }

        private void InitializePositionTab()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            var lblHeader = new Label
            {
                Text = "💼 Position Management",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(20, 20),
                Size = new Size(400, 40)
            };

            var lblComingSoon = new Label
            {
                Text = "💼 Position management features coming soon...\n\n" +
                       "• Job Title Management\n" +
                       "• Position Hierarchy\n" +
                       "• Salary Ranges\n" +
                       "• Required Skills\n" +
                       "• Career Path Planning",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                ForeColor = Color.LightGray,
                Location = new Point(20, 80),
                Size = new Size(600, 200)
            };

            panel.Controls.Add(lblHeader);
            panel.Controls.Add(lblComingSoon);
            this.tabPositions.Controls.Add(panel);
        }

        private async void LoadDepartments()
        {
            try
            {
                // Show loading indicator
                ShowLoadingIndicator(true);

                // Create request for DepartmentService
                var request = new BusinessLogic.Dtos.Requests.Department.DepartmentRequest
                {
                    PageNumber = currentPage,
                    PageSize = pageSize,
                    Keyword = searchKeyword
                };

                // Call DepartmentService
                var result = await _departmentService.GetPagination(request);

                if (result.Succeeded)
                {
                    // Update pagination info
                    totalRecords = result.TotalCount;
                    totalPages = result.TotalPages;
                    currentPage = result.CurrentPage;

                    // Clear and populate DataGridView
                    dgvDepartments.Rows.Clear();
                    foreach (var dept in result.Data)
                    {
                        dgvDepartments.Rows.Add(
                            dept.Id,
                            dept.DeptName,
                            dept.Description,
                            dept.CreatedBy,
                            dept.CreatedOn.ToString("yyyy-MM-dd HH:mm")
                        );
                    }

                    // Update pagination controls
                    UpdatePaginationControls();
                }
                else
                {
                    // Handle service errors
                    string errorMessage = result.Messages?.Count > 0 ? string.Join("\n", result.Messages) : "Unknown error occurred";
                    MessageBox.Show($"Error loading departments: {errorMessage}", "Service Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Hide loading indicator
                ShowLoadingIndicator(false);
            }
        }

        private void ShowLoadingIndicator(bool show)
        {
            // You can implement a loading spinner or progress bar here
            if (show)
            {
                Cursor = Cursors.WaitCursor;
                btnRefresh.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                Cursor = Cursors.Default;
                btnRefresh.Enabled = true;
                btnSearch.Enabled = true;
            }
        }

        private void UpdatePaginationControls()
        {
            // Update page info
            lblPageInfo.Text = $"Page {currentPage} of {totalPages} (Total: {totalRecords} records)";

            // Update button states
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;

            // Update button colors
            btnPrevious.BackColor = btnPrevious.Enabled ? Color.FromArgb(0, 122, 204) : Color.FromArgb(70, 70, 70);
            btnNext.BackColor = btnNext.Enabled ? Color.FromArgb(0, 122, 204) : Color.FromArgb(70, 70, 70);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadDepartments();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadDepartments();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchKeyword = txtSearch.Text.Trim();
            currentPage = 1; // Reset to first page
            LoadDepartments();
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            searchKeyword = "";
            currentPage = 1;
            LoadDepartments();
        }

        private void CmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPageSize.SelectedItem != null)
            {
                pageSize = (int)cmbPageSize.SelectedItem;
                currentPage = 1; // Reset to first page
                LoadDepartments();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private async void BtnAddDepartment_Click(object sender, EventArgs e)
        {
            // Simple add department form
            var form = new Form
            {
                Text = "Add Department",
                Size = new Size(450, 350),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            var lblName = new Label 
            { 
                Text = "Department Name:", 
                Location = new Point(20, 30), 
                Size = new Size(120, 20),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White
            };
            
            var txtName = new TextBox 
            { 
                Location = new Point(20, 55), 
                Size = new Size(400, 25),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            
            var lblDesc = new Label 
            { 
                Text = "Description:", 
                Location = new Point(20, 90), 
                Size = new Size(120, 20),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White
            };
            
            var txtDesc = new TextBox 
            { 
                Text = "Description:", 
                Location = new Point(20, 115), 
                Size = new Size(400, 80), 
                Multiline = true,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var btnSave = new Button
            {
                Text = "💾 Save",
                Location = new Point(200, 250),
                Size = new Size(100, 35),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            var btnCancel = new Button
            {
                Text = "❌ Cancel",
                Location = new Point(320, 250),
                Size = new Size(100, 35),
                Font = new Font("Segoe UI", 10),
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnSave.Click += async (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Department name is required!", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Create DepartmentResponse for service
                    var departmentRequest = new DepartmentResponse
                    {
                        DeptName = txtName.Text.Trim(),
                        Description = txtDesc.Text.Trim(),
                        CreatedBy = "Current User" // You can get this from authentication context
                    };

                    // Call DepartmentService to add department
                    var result = await _departmentService.Add(departmentRequest);

                    if (result.Succeeded)
                    {
                        MessageBox.Show($"Department '{txtName.Text}' added successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.Close();
                        LoadDepartments(); // Refresh the grid
                    }
                    else
                    {
                        string errorMessage = result.Messages?.Count > 0 ? string.Join("\n", result.Messages) : "Unknown error occurred";
                        MessageBox.Show($"Error adding department: {errorMessage}", "Service Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding department: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            btnCancel.Click += (s, args) => form.Close();

            form.Controls.AddRange(new Control[] { lblName, txtName, lblDesc, txtDesc, btnSave, btnCancel });
            form.ShowDialog();
        }
    }
}
