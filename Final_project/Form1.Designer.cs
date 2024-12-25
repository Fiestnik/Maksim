namespace Final_project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvTasks = new DataGridView();
            txtTaskName = new TextBox();
            cmbStatus = new ComboBox();
            dtpDeadline = new DateTimePicker();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();

            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(50, 30);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(700, 200);
            dgvTasks.TabIndex = 0;
            dgvTasks.SelectionChanged += new EventHandler(dgvTasks_SelectionChanged);

            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(50, 250);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(200, 23);
            txtTaskName.TabIndex = 1;

            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(300, 250);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 23);
            cmbStatus.TabIndex = 2;
            cmbStatus.SelectedIndexChanged += new EventHandler(cmbStatus_SelectedIndexChanged);

            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(500, 250);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(200, 23);
            dtpDeadline.TabIndex = 3;

            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(50, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;

            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;

            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(350, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 30);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dtpDeadline);
            Controls.Add(cmbStatus);
            Controls.Add(txtTaskName);
            Controls.Add(dgvTasks);
            Name = "Form1";
            Text = "Task Manager";
            Load += new EventHandler(Form1_Load);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTasks;
        private TextBox txtTaskName;
        private ComboBox cmbStatus;
        private DateTimePicker dtpDeadline;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
    }
}
