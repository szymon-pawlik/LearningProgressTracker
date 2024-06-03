using System;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class ViewTasksForm : Form
    {
        public ViewTasksForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewTasks = new DataGridView();
            this.editButtonColumn = new DataGridViewButtonColumn();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] {
            this.editButtonColumn});
            this.dataGridViewTasks.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(760, 437);
            this.dataGridViewTasks.TabIndex = 0;
            this.dataGridViewTasks.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewTasks_CellContentClick);
            // 
            // editButtonColumn
            // 
            this.editButtonColumn.HeaderText = "Edit";
            this.editButtonColumn.Name = "editButtonColumn";
            this.editButtonColumn.Text = "Edit";
            this.editButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewTasksForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "ViewTasksForm";
            this.Text = "View Tasks";
            this.Load += new EventHandler(this.ViewTasksForm_Load);
            this.ResumeLayout(false);

        }

        private void ViewTasksForm_Load(object sender, EventArgs e)
        {
            // Load tasks into DataGridView
            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = MainForm.Tasks;
        }

        private void dataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTasks.Columns["editButtonColumn"].Index && e.RowIndex >= 0)
            {
                var task = MainForm.Tasks[e.RowIndex];
                var editTaskForm = new EditTaskForm(task);
                editTaskForm.ShowDialog();

                // Refresh the DataGridView after editing
                dataGridViewTasks.DataSource = null;
                dataGridViewTasks.DataSource = MainForm.Tasks;
            }
        }

        private DataGridView dataGridViewTasks;
        private DataGridViewButtonColumn editButtonColumn;
    }
}
