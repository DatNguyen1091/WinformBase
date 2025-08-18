using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using BusinessLogic.Services;
using BusinessLogic.Dtos.Requests.Department;
using BusinessLogic.Dtos.Responses.Department;
using BusinessLogic.Wrapper;

namespace WinformBase.Forms.CompanyManagement.Components
{
    public partial class DepartmentComponent : UserControl
    {
        private DataGridView dgvDepartments;
        private Button btnAddDepartment;
        private Button btnEditDepartment;
        private Button btnDeleteDepartment;
        private Button btnClearSearch;
        private Button btnSearch;
        private TextBox txtSearchDepartment;
        private Label lblSearchDepartment;

        // Service
        private readonly DepartmentService _departmentService;

        // Pagination variables
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalPages = 0;
        private int totalRecords = 0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private string searchKeyword = "";

        public DepartmentComponent()
        {
            InitializeComponent();
            InitializeEvents();
            _departmentService = new DepartmentService();
            LoadDepartments();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchDepartment = new System.Windows.Forms.TextBox();
            this.lblSearchDepartment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvDepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartments.EnableHeadersVisualStyles = false;
            this.dgvDepartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDepartments.Location = new System.Drawing.Point(21, 50);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersVisible = false;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(634, 329);
            this.dgvDepartments.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Department Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Created By";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Created On";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(480, 16);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(77, 28);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "➕ Add";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditDepartment.ForeColor = System.Drawing.Color.Black;
            this.btnEditDepartment.Location = new System.Drawing.Point(566, 16);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(77, 28);
            this.btnEditDepartment.TabIndex = 3;
            this.btnEditDepartment.Text = "✏️ Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(651, 16);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(77, 28);
            this.btnDeleteDepartment.TabIndex = 4;
            this.btnDeleteDepartment.Text = "🗑️ Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(394, 16);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(77, 28);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "🗑️ Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(300, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchDepartment
            // 
            this.txtSearchDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtSearchDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchDepartment.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchDepartment.Location = new System.Drawing.Point(89, 16);
            this.txtSearchDepartment.Name = "txtSearchDepartment";
            this.txtSearchDepartment.Size = new System.Drawing.Size(205, 25);
            this.txtSearchDepartment.TabIndex = 1;
            this.txtSearchDepartment.Text = "Enter department name or description...";
            // 
            // lblSearchDepartment
            // 
            this.lblSearchDepartment.AutoSize = true;
            this.lblSearchDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchDepartment.ForeColor = System.Drawing.Color.White;
            this.lblSearchDepartment.Location = new System.Drawing.Point(17, 17);
            this.lblSearchDepartment.Name = "lblSearchDepartment";
            this.lblSearchDepartment.Size = new System.Drawing.Size(75, 19);
            this.lblSearchDepartment.TabIndex = 0;
            this.lblSearchDepartment.Text = "🔍 Search:";
            // 
            // DepartmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnEditDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDepartment);
            this.Controls.Add(this.lblSearchDepartment);
            this.Name = "DepartmentComponent";
            this.Size = new System.Drawing.Size(686, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeEvents()
        {
            btnAddDepartment.Click += BtnAddDepartment_Click;
            btnEditDepartment.Click += BtnEditDepartment_Click;
            btnDeleteDepartment.Click += BtnDeleteDepartment_Click;
            btnClearSearch.Click += BtnClearSearch_Click;
            btnSearch.Click += BtnSearch_Click;
            txtSearchDepartment.TextChanged += TxtSearchDepartment_TextChanged;
            txtSearchDepartment.KeyPress += TxtSearchDepartment_KeyPress;
            txtSearchDepartment.GotFocus += TxtSearchDepartment_GotFocus;
            txtSearchDepartment.LostFocus += TxtSearchDepartment_LostFocus;
            dgvDepartments.CellDoubleClick += DgvDepartments_CellDoubleClick;
        }

        private async void BtnAddDepartment_Click(object sender, EventArgs e)
        {
            // Modern add department form
            var form = new Form
            {
                Text = "➕ Add New Department",
                Size = new Size(500, 400),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                Icon = SystemIcons.Information
            };

            // Header label
            var lblHeader = new Label
            {
                Text = "Create New Department",
                Location = new Point(20, 20),
                Size = new Size(460, 30),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 122, 204),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblName = new Label
            {
                Text = "🏢 Department Name:",
                Location = new Point(20, 70),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White
            };

            var txtName = new TextBox
            {
                Location = new Point(20, 100),
                Size = new Size(460, 30),
                Font = new Font("Segoe UI", 11F),
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.Gray,
                BorderStyle = BorderStyle.FixedSingle,
                Text = "Enter department name (e.g., Information Technology)"
            };

            var lblDesc = new Label
            {
                Text = "📝 Description:",
                Location = new Point(20, 150),
                Size = new Size(150, 25),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.White
            };

            var txtDesc = new TextBox
            {
                Location = new Point(20, 180),
                Size = new Size(460, 100),
                Multiline = true,
                Font = new Font("Segoe UI", 10F),
                BackColor = Color.FromArgb(45, 45, 48),
                ForeColor = Color.Gray,
                BorderStyle = BorderStyle.FixedSingle,
                Text = "Enter department description..."
            };

            var btnSave = new Button
            {
                Text = "💾 Save Department",
                Location = new Point(200, 310),
                Size = new Size(130, 40),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(0, 122, 204),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            var btnCancel = new Button
            {
                Text = "❌ Cancel",
                Location = new Point(350, 310),
                Size = new Size(130, 40),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                BackColor = Color.FromArgb(70, 70, 70),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnSave.Click += async (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || 
                    txtName.Text == "Enter department name (e.g., Information Technology)")
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

            // Add placeholder behavior for text boxes
            txtName.GotFocus += (s, args) =>
            {
                if (txtName.Text == "Enter department name (e.g., Information Technology)")
                {
                    txtName.Text = "";
                    txtName.ForeColor = Color.White;
                }
            };

            txtName.LostFocus += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    txtName.Text = "Enter department name (e.g., Information Technology)";
                    txtName.ForeColor = Color.Gray;
                }
            };

            txtDesc.GotFocus += (s, args) =>
            {
                if (txtDesc.Text == "Enter department description...")
                {
                    txtDesc.Text = "";
                    txtDesc.ForeColor = Color.White;
                }
            };

            txtDesc.LostFocus += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(txtDesc.Text))
                {
                    txtDesc.Text = "Enter department description...";
                    txtDesc.ForeColor = Color.Gray;
                }
            };

            form.Controls.AddRange(new Control[] { lblHeader, lblName, txtName, lblDesc, txtDesc, btnSave, btnCancel });
            form.ShowDialog();
        }

        private async void BtnEditDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDepartments.SelectedRows[0];
                var departmentId = Convert.ToInt64(selectedRow.Cells["Id"].Value);
                var departmentName = selectedRow.Cells["DeptName"].Value.ToString();
                var departmentDesc = selectedRow.Cells["Description"].Value.ToString();

                // Modern edit department form
                var form = new Form
                {
                    Text = "✏️ Edit Department",
                    Size = new Size(500, 400),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    BackColor = Color.FromArgb(30, 30, 30),
                    ForeColor = Color.White,
                    Icon = SystemIcons.Information
                };

                // Header label
                var lblHeader = new Label
                {
                    Text = "Edit Department",
                    Location = new Point(20, 20),
                    Size = new Size(460, 30),
                    Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(255, 193, 7),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var lblName = new Label
                {
                    Text = "🏢 Department Name:",
                    Location = new Point(20, 70),
                    Size = new Size(150, 25),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = Color.White
                };

                var txtName = new TextBox
                {
                    Text = departmentName,
                    Location = new Point(20, 100),
                    Size = new Size(460, 30),
                    Font = new Font("Segoe UI", 11F),
                    BackColor = Color.FromArgb(45, 45, 48),
                    ForeColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var lblDesc = new Label
                {
                    Text = "📝 Description:",
                    Location = new Point(20, 150),
                    Size = new Size(150, 25),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    ForeColor = Color.White
                };

                var txtDesc = new TextBox
                {
                    Text = departmentDesc,
                    Location = new Point(20, 180),
                    Size = new Size(460, 48),
                    Multiline = true,
                    Font = new Font("Segoe UI", 10F),
                    BackColor = Color.FromArgb(45, 45, 48),
                    ForeColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var btnSave = new Button
                {
                    Text = "💾 Update Department",
                    Location = new Point(200, 310),
                    Size = new Size(130, 40),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    BackColor = Color.FromArgb(0, 122, 204),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };

                var btnCancel = new Button
                {
                    Text = "❌ Cancel",
                    Location = new Point(350, 310),
                    Size = new Size(130, 40),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    BackColor = Color.FromArgb(70, 70, 70),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };

                btnSave.Click += async (s, args) =>
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text) || 
                        txtName.Text == "Enter department name (e.g., Information Technology)")
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
                            Id = departmentId,
                            DeptName = txtName.Text.Trim(),
                            Description = txtDesc.Text.Trim(),
                            LastModifiedBy = "Current User" // You can get this from authentication context
                        };

                        // Call DepartmentService to update department
                        var result = await _departmentService.Update(departmentRequest);

                        if (result.Succeeded)
                        {
                            MessageBox.Show($"Department '{txtName.Text}' updated successfully!", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.Close();
                            LoadDepartments(); // Refresh the grid
                        }
                        else
                        {
                            string errorMessage = result.Messages?.Count > 0 ? string.Join("\n", result.Messages) : "Unknown error occurred";
                            MessageBox.Show($"Error updating department: {errorMessage}", "Service Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating department: {ex.Message}", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                btnCancel.Click += (s, args) => form.Close();

                form.Controls.AddRange(new Control[] { lblHeader, lblName, txtName, lblDesc, txtDesc, btnSave, btnCancel });
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a department to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void BtnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDepartments.SelectedRows[0];
                var departmentId = Convert.ToInt64(selectedRow.Cells["Id"].Value);
                var departmentName = selectedRow.Cells["DeptName"].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to delete department '{departmentName}'?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Call DepartmentService to delete department
                        var result = await _departmentService.Delete(departmentId);

                        if (result.Succeeded)
                        {
                            MessageBox.Show($"Department '{departmentName}' deleted successfully!", "Success", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDepartments(); // Refresh the grid
                        }
                        else
                        {
                            string errorMessage = result.Messages?.Count > 0 ? string.Join("\n", result.Messages) : "Unknown error occurred";
                            MessageBox.Show($"Error deleting department: {errorMessage}", "Service Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting department: {ex.Message}", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtSearchDepartment_TextChanged(object sender, EventArgs e)
        {
            // Don't search if it's placeholder text
            if (txtSearchDepartment.Text == "Enter department name or description...")
            {
                searchKeyword = "";
                return;
            }

            // Update search keyword
            searchKeyword = txtSearchDepartment.Text.Trim();
            currentPage = 1; // Reset to first page
            
            // Don't call LoadDepartments here - let user press Enter or lose focus
            // This prevents calling service on every keystroke
        }

        private void TxtSearchDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Search when Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound
                PerformSearch();
            }
        }

        private void PerformSearch()
        {
            // Don't search if it's placeholder text
            if (txtSearchDepartment.Text == "Enter department name or description...")
            {
                searchKeyword = "";
                LoadDepartments(); // Load all departments
                return;
            }

            // Perform search with current keyword
            searchKeyword = txtSearchDepartment.Text.Trim();
            if (!string.IsNullOrWhiteSpace(searchKeyword))
            {
                LoadDepartments(); // Search with keyword
            }
            else
            {
                searchKeyword = "";
                LoadDepartments(); // Load all departments
            }
        }

        private void TxtSearchDepartment_GotFocus(object sender, EventArgs e)
        {
            // Clear placeholder text when focused
            if (txtSearchDepartment.Text == "Enter department name or description...")
            {
                txtSearchDepartment.Text = "";
                txtSearchDepartment.ForeColor = Color.White;
                searchKeyword = ""; // Reset search keyword
            }
        }

        private void TxtSearchDepartment_LostFocus(object sender, EventArgs e)
        {
            // Restore placeholder text when lost focus
            if (string.IsNullOrWhiteSpace(txtSearchDepartment.Text))
            {
                txtSearchDepartment.Text = "Enter department name or description...";
                txtSearchDepartment.ForeColor = Color.Gray;
                searchKeyword = ""; // Reset search keyword
                LoadDepartments(); // Reload all departments
            }
            else
            {
                // If there's actual text, perform search
                PerformSearch();
            }
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void DgvDepartments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Implement double-click to edit functionality
                BtnEditDepartment_Click(sender, e);
            }
        }

        public async void LoadDepartments()
        {
            try
            {
                // Show loading indicator
                ShowLoadingIndicator(true);

                // Create request for DepartmentService
                var request = new DepartmentRequest
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
                }
                else
                {
                    // Handle service errors
                    string errorMessage = result.Messages?.Count > 0 ? string.Join("\n", result.Messages) : "Unknown error occurred";
                    MessageBox.Show($"Error loading departments: {errorMessage}", "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void RefreshData()
        {
            LoadDepartments();
        }

        public void ClearSearch()
        {
            txtSearchDepartment.Text = "Enter department name or description...";
            txtSearchDepartment.ForeColor = Color.Gray;
            searchKeyword = "";
            currentPage = 1;
            PerformSearch(); // Use PerformSearch instead of LoadDepartments directly
        }

        private void ShowLoadingIndicator(bool show)
        {
            if (show)
            {
                Cursor = Cursors.WaitCursor;
                btnAddDepartment.Enabled = false;
                btnEditDepartment.Enabled = false;
                btnDeleteDepartment.Enabled = false;
                btnClearSearch.Enabled = false;
                btnSearch.Enabled = false;
                txtSearchDepartment.Enabled = false;
                
                // Change button text to show loading state
                btnAddDepartment.Text = "⏳ Loading...";
                btnEditDepartment.Text = "⏳ Loading...";
                btnDeleteDepartment.Text = "⏳ Loading...";
                btnClearSearch.Text = "⏳ Loading...";
                btnSearch.Text = "⏳ Loading...";
                
                // Change button colors to indicate disabled state
                btnAddDepartment.BackColor = Color.FromArgb(100, 100, 100);
                btnEditDepartment.BackColor = Color.FromArgb(100, 100, 100);
                btnDeleteDepartment.BackColor = Color.FromArgb(100, 100, 100);
                btnClearSearch.BackColor = Color.FromArgb(100, 100, 100);
                btnSearch.BackColor = Color.FromArgb(100, 100, 100);
            }
            else
            {
                Cursor = Cursors.Default;
                btnAddDepartment.Enabled = true;
                btnEditDepartment.Enabled = true;
                btnDeleteDepartment.Enabled = true;
                btnClearSearch.Enabled = true;
                btnSearch.Enabled = true;
                txtSearchDepartment.Enabled = true;
                
                // Restore button text
                btnAddDepartment.Text = "➕ Add";
                btnEditDepartment.Text = "✏️ Edit";
                btnDeleteDepartment.Text = "🗑️ Delete";
                btnClearSearch.Text = "🗑️ Clear";
                btnSearch.Text = "🔍 Search";
                
                // Restore button colors
                btnAddDepartment.BackColor = Color.FromArgb(0, 122, 204);
                btnEditDepartment.BackColor = Color.FromArgb(255, 193, 7);
                btnDeleteDepartment.BackColor = Color.FromArgb(220, 53, 69);
                btnClearSearch.BackColor = Color.FromArgb(108, 117, 125);
                btnSearch.BackColor = Color.FromArgb(40, 167, 69);
            }
        }
    }
}
