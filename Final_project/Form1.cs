namespace Final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += new EventHandler(btnAdd_Click);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            cmbStatus.SelectedIndexChanged += new EventHandler(cmbStatus_SelectedIndexChanged);
            dgvTasks.SelectionChanged += new EventHandler(dgvTasks_SelectionChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
            InitializeDataGridView();
        }

        private void InitializeComboBox()
        {
            if (cmbStatus != null)
            {
                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(new string[] { "Pending", "In Progress", "Completed" });
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("ComboBox 'cmbStatus' is not initialized.");
            }
        }

        private void InitializeDataGridView()
        {
            if (dgvTasks != null)
            {
                dgvTasks.ColumnCount = 3;
                dgvTasks.Columns[0].Name = "Task Name";
                dgvTasks.Columns[1].Name = "Status";
                dgvTasks.Columns[2].Name = "Deadline";
                dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTasks.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("DataGridView 'dgvTasks' is not initialized.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Please enter a task name.");
                return;
            }

            dgvTasks.Rows.Add(txtTaskName.Text, cmbStatus.SelectedItem?.ToString(), dtpDeadline.Value.ToShortDateString());
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTasks.SelectedRows)
                {
                    dgvTasks.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            DataGridViewRow selectedRow = dgvTasks.SelectedRows[0];
            selectedRow.Cells[0].Value = txtTaskName.Text;
            selectedRow.Cells[1].Value = cmbStatus.SelectedItem?.ToString();
            selectedRow.Cells[2].Value = dtpDeadline.Value.ToShortDateString();

            ClearInputs();
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvTasks.SelectedRows[0];
                txtTaskName.Text = selectedRow.Cells[0].Value?.ToString();
                cmbStatus.SelectedItem = selectedRow.Cells[1].Value?.ToString();
                dtpDeadline.Value = DateTime.TryParse(selectedRow.Cells[2].Value?.ToString(), out DateTime date) ? date : DateTime.Now;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearInputs()
        {
            txtTaskName.Clear();
            cmbStatus.SelectedIndex = 0;
            dtpDeadline.Value = DateTime.Now;
        }
    }
}

