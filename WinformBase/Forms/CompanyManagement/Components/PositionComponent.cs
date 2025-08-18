using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinformBase.Forms.CompanyManagement.Components
{
    public partial class PositionComponent : UserControl
    {
        private DataGridView dgvPositions;
        private Button btnAddPosition;
        private Button btnEditPosition;
        private Button btnDeletePosition;
        private TextBox txtSearchPosition;
        private Label lblSearchPosition;
        private ComboBox cboDepartmentFilter;
        private Label lblDepartmentFilter;

        public PositionComponent()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeComponent()
        {
            this.dgvPositions = new DataGridView();
            this.btnAddPosition = new Button();
            this.btnEditPosition = new Button();
            this.btnDeletePosition = new Button();
            this.txtSearchPosition = new TextBox();
            this.lblSearchPosition = new Label();
            this.cboDepartmentFilter = new ComboBox();
            this.lblDepartmentFilter = new Label();

            // 
            // lblSearchPosition
            // 
            this.lblSearchPosition.AutoSize = true;
            this.lblSearchPosition.Location = new Point(10, 15);
            this.lblSearchPosition.Name = "lblSearchPosition";
            this.lblSearchPosition.Size = new Size(41, 13);
            this.lblSearchPosition.Text = "Search:";
            this.lblSearchPosition.TabIndex = 0;

            // 
            // txtSearchPosition
            // 
            this.txtSearchPosition.Location = new Point(60, 12);
            this.txtSearchPosition.Name = "txtSearchPosition";
            this.txtSearchPosition.Size = new Size(200, 20);
            this.txtSearchPosition.TabIndex = 1;

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
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new Point(520, 10);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new Size(75, 23);
            this.btnAddPosition.TabIndex = 4;
            this.btnAddPosition.Text = "Add";
            this.btnAddPosition.UseVisualStyleBackColor = true;

            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Location = new Point(605, 10);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new Size(75, 23);
            this.btnEditPosition.TabIndex = 5;
            this.btnEditPosition.Text = "Edit";
            this.btnEditPosition.UseVisualStyleBackColor = true;

            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Location = new Point(690, 10);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new Size(75, 23);
            this.btnDeletePosition.TabIndex = 6;
            this.btnDeletePosition.Text = "Delete";
            this.btnDeletePosition.UseVisualStyleBackColor = true;

            // 
            // dgvPositions
            // 
            this.dgvPositions.AllowUserToAddRows = false;
            this.dgvPositions.AllowUserToDeleteRows = false;
            this.dgvPositions.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
            this.dgvPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Location = new Point(10, 45);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.ReadOnly = true;
            this.dgvPositions.RowHeadersVisible = false;
            this.dgvPositions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPositions.Size = new Size(760, 400);
            this.dgvPositions.TabIndex = 7;

            // 
            // PositionComponent
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.dgvPositions);
            this.Controls.Add(this.btnDeletePosition);
            this.Controls.Add(this.btnEditPosition);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.cboDepartmentFilter);
            this.Controls.Add(this.lblDepartmentFilter);
            this.Controls.Add(this.txtSearchPosition);
            this.Controls.Add(this.lblSearchPosition);
            this.Name = "PositionComponent";
            this.Size = new Size(780, 460);
            this.TabIndex = 0;
        }

        private void InitializeEvents()
        {
            btnAddPosition.Click += BtnAddPosition_Click;
            btnEditPosition.Click += BtnEditPosition_Click;
            btnDeletePosition.Click += BtnDeletePosition_Click;
            txtSearchPosition.TextChanged += TxtSearchPosition_TextChanged;
            cboDepartmentFilter.SelectedIndexChanged += CboDepartmentFilter_SelectedIndexChanged;
            dgvPositions.CellDoubleClick += DgvPositions_CellDoubleClick;
        }

        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            // TODO: Implement Add Position logic
            MessageBox.Show("Add Position functionality will be implemented here.");
        }

        private void BtnEditPosition_Click(object sender, EventArgs e)
        {
            if (dgvPositions.SelectedRows.Count > 0)
            {
                // TODO: Implement Edit Position logic
                MessageBox.Show("Edit Position functionality will be implemented here.");
            }
            else
            {
                MessageBox.Show("Please select a position to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDeletePosition_Click(object sender, EventArgs e)
        {
            if (dgvPositions.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this position?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // TODO: Implement Delete Position logic
                    MessageBox.Show("Delete Position functionality will be implemented here.");
                }
            }
            else
            {
                MessageBox.Show("Please select a position to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtSearchPosition_TextChanged(object sender, EventArgs e)
        {
            // TODO: Implement search functionality
            // Filter positions based on search text
        }

        private void CboDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Implement department filter functionality
            // Filter positions by selected department
        }

        private void DgvPositions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // TODO: Implement double-click to edit functionality
                MessageBox.Show("Double-click functionality will be implemented here.");
            }
        }

        public void LoadPositions()
        {
            // TODO: Load positions from database
            // This method will be called from parent form
        }

        public void LoadDepartments()
        {
            // TODO: Load departments for filter combo box
            // This method will be called from parent form
        }

        public void RefreshData()
        {
            // TODO: Refresh position data
            LoadPositions();
        }
    }
}
