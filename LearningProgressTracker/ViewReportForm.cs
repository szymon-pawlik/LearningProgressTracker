using System;
using System.Linq;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class ViewReportForm : Form
    {
        public ViewReportForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridViewReport = new DataGridView();
            this.editButtonColumn = new DataGridViewButtonColumn();
            this.deleteButtonColumn = new DataGridViewButtonColumn();
            this.SuspendLayout();
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new DataGridViewColumn[] {
            this.editButtonColumn,
            this.deleteButtonColumn});
            this.dataGridViewReport.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(760, 437);
            this.dataGridViewReport.TabIndex = 0;
            this.dataGridViewReport.CellContentClick += new DataGridViewCellEventHandler(this.dataGridViewReport_CellContentClick);
            // 
            // editButtonColumn
            // 
            this.editButtonColumn.HeaderText = "Edit";
            this.editButtonColumn.Name = "editButtonColumn";
            this.editButtonColumn.Text = "Edit";
            this.editButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteButtonColumn
            // 
            this.deleteButtonColumn.HeaderText = "Delete";
            this.deleteButtonColumn.Name = "deleteButtonColumn";
            this.deleteButtonColumn.Text = "Delete";
            this.deleteButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewReport);
            this.Name = "ViewReportForm";
            this.Text = "View Report";
            this.Load += new EventHandler(this.ViewReportForm_Load);
            this.ResumeLayout(false);

        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            // Load report data into DataGridView
            var reportData = MainForm.Grades.Select(g => new
            {
                TaskTitle = g.TaskTitle,
                Score = g.Score,
                Comments = g.Comments
            }).ToList();

            dataGridViewReport.DataSource = reportData;
        }

        private void dataGridViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewReport.Columns["editButtonColumn"].Index && e.RowIndex >= 0)
            {
                var grade = MainForm.Grades[e.RowIndex];
                var editGradeForm = new EditGradeForm(grade);
                editGradeForm.ShowDialog();

                // Refresh the DataGridView after editing
                dataGridViewReport.DataSource = null;
                var reportData = MainForm.Grades.Select(g => new
                {
                    TaskTitle = g.TaskTitle,
                    Score = g.Score,
                    Comments = g.Comments
                }).ToList();
                dataGridViewReport.DataSource = reportData;
            }
            else if (e.ColumnIndex == dataGridViewReport.Columns["deleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                var grade = MainForm.Grades[e.RowIndex];
                var result = MessageBox.Show($"Are you sure you want to delete the grade for task '{grade.TaskTitle}'?", "Delete Grade", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MainForm.Grades.Remove(grade);

                    // Refresh the DataGridView after deleting
                    dataGridViewReport.DataSource = null;
                    var reportData = MainForm.Grades.Select(g => new
                    {
                        TaskTitle = g.TaskTitle,
                        Score = g.Score,
                        Comments = g.Comments
                    }).ToList();
                    dataGridViewReport.DataSource = reportData;
                }
            }
        }

        private DataGridView dataGridViewReport;
        private DataGridViewButtonColumn editButtonColumn;
        private DataGridViewButtonColumn deleteButtonColumn;
    }
}
