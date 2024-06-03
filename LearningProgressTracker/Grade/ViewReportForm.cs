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
            this.dataGridViewReport.CellContentClick += new DataGridViewCellEventHandler(this.DataGridViewReport_CellContentClick);
            // 
            // editButtonColumn
            // 
            this.editButtonColumn.HeaderText = "Edytuj";
            this.editButtonColumn.Name = "editButtonColumn";
            this.editButtonColumn.Text = "Edytuj";
            this.editButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteButtonColumn
            // 
            this.deleteButtonColumn.HeaderText = "Usuń";
            this.deleteButtonColumn.Name = "deleteButtonColumn";
            this.deleteButtonColumn.Text = "Usuń";
            this.deleteButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewReport);
            this.Name = "ViewReportForm";
            this.Text = "Zobacz raport";
            this.Load += new EventHandler(this.ViewReportForm_Load);
            this.ResumeLayout(false);

        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            // załaduj dane do raportu
            var reportData = MainForm.Grades.Select(g => new
            {
                Zadanie = g.TaskTitle,
                Wynik = g.Score / 10.0, 
                Komentarz = g.Comments
            }).ToList();

            dataGridViewReport.DataSource = reportData;

            // ustaw nagłówki kolumn na polskie
            dataGridViewReport.Columns["Zadanie"].HeaderText = "Zadanie";
            dataGridViewReport.Columns["Wynik"].HeaderText = "Wynik";
            dataGridViewReport.Columns["Komentarz"].HeaderText = "Komentarz";
        }

        private void DataGridViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewReport.Columns["editButtonColumn"].Index && e.RowIndex >= 0)
            {
                var grade = MainForm.Grades[e.RowIndex];
                var editGradeForm = new EditGradeForm(grade);
                editGradeForm.ShowDialog();

                // odśwież DataGridView po edycji
                dataGridViewReport.DataSource = null;
                var reportData = MainForm.Grades.Select(g => new
                {
                    Zadanie = g.TaskTitle,
                    Wynik = g.Score / 10.0, 
                    Komentarz = g.Comments
                }).ToList();
                dataGridViewReport.DataSource = reportData;

                // ustal nagłówki kolumn na polskie
                dataGridViewReport.Columns["Zadanie"].HeaderText = "Zadanie";
                dataGridViewReport.Columns["Wynik"].HeaderText = "Wynik";
                dataGridViewReport.Columns["Komentarz"].HeaderText = "Komentarz";
            }
            else if (e.ColumnIndex == dataGridViewReport.Columns["deleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                var grade = MainForm.Grades[e.RowIndex];
                var result = MessageBox.Show($"Na pewno chcesz usunąć ocenę dla zadania '{grade.TaskTitle}'?", "Usuń ocenę", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MainForm.Grades.Remove(grade);

                    // Odśwież DataGridView po usunięciu
                    dataGridViewReport.DataSource = null;
                    var reportData = MainForm.Grades.Select(g => new
                    {
                        Zadanie = g.TaskTitle,
                        Wynik = g.Score / 10.0,
                        Komentarz = g.Comments
                    }).ToList();
                    dataGridViewReport.DataSource = reportData;

                    // ustal nagłówki kolumn na polskie
                    dataGridViewReport.Columns["Zadanie"].HeaderText = "Zadanie";
                    dataGridViewReport.Columns["Wynik"].HeaderText = "Wynik";
                    dataGridViewReport.Columns["Komentarz"].HeaderText = "Komentarz";
                }
            }
        }

        private DataGridView dataGridViewReport;
        private DataGridViewButtonColumn editButtonColumn;
        private DataGridViewButtonColumn deleteButtonColumn;
    }
}
