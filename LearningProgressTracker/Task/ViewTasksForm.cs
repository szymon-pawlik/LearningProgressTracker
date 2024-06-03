using System;
using System.Drawing;
using System.Linq;
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
            this.deleteButtonColumn = new DataGridViewButtonColumn();
            this.viewSolutionButtonColumn = new DataGridViewButtonColumn();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] {
                this.editButtonColumn,
                this.deleteButtonColumn,
                this.viewSolutionButtonColumn});
            this.dataGridViewTasks.Location = new Point(12, 12);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new Size(960, 537);
            this.dataGridViewTasks.TabIndex = 0;
            this.dataGridViewTasks.CellContentClick += new DataGridViewCellEventHandler(this.DataGridViewTasks_CellContentClick);
            this.dataGridViewTasks.CellDoubleClick += new DataGridViewCellEventHandler(this.DataGridViewTasks_CellDoubleClick);
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
            // viewSolutionButtonColumn
            // 
            this.viewSolutionButtonColumn.HeaderText = "Wyświetl rozwiązanie";
            this.viewSolutionButtonColumn.Name = "viewSolutionButtonColumn";
            this.viewSolutionButtonColumn.Text = "Wyświetl";
            this.viewSolutionButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ViewTasksForm
            // 
            this.ClientSize = new Size(984, 561);
            this.Controls.Add(this.dataGridViewTasks);
            this.Name = "ViewTasksForm";
            this.Text = "Wyświetl zadania";
            this.Load += new EventHandler(this.ViewTasksForm_Load);
            this.ResumeLayout(false);

        }

        private void ViewTasksForm_Load(object sender, EventArgs e)
        {
            // Load tasks data into DataGridView
            var tasksData = MainForm.Tasks.Select(t => new
            {
                Tytul = t.Title,
                Opis = t.Description,
                TerminOddania = t.DueDate.ToString("dd.MM.yyyy HH:mm"),
                RozwiazanieNauczyciela = t.TeacherSolution,
                RozwiazanieUcznia = t.StudentSolution,
                DataWyslania = t.SubmissionDate.HasValue ? t.SubmissionDate.Value.ToString("dd.MM.yyyy HH:mm") : "Nie wysłano"
            }).ToList();

            dataGridViewTasks.DataSource = tasksData;

            // Set column headers to Polish
            dataGridViewTasks.Columns["Tytul"].HeaderText = "Tytuł";
            dataGridViewTasks.Columns["Opis"].HeaderText = "Opis";
            dataGridViewTasks.Columns["TerminOddania"].HeaderText = "Termin oddania";
            dataGridViewTasks.Columns["RozwiazanieNauczyciela"].HeaderText = "Rozwiązanie nauczyciela";
            dataGridViewTasks.Columns["RozwiazanieUcznia"].HeaderText = "Rozwiązanie ucznia";
            dataGridViewTasks.Columns["DataWyslania"].HeaderText = "Data wysłania";
        }

        private void DataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTasks.Columns["editButtonColumn"].Index && e.RowIndex >= 0)
            {
                var task = MainForm.Tasks[e.RowIndex];
                var editTaskForm = new EditTaskForm(task);
                editTaskForm.ShowDialog();

                // Refresh the DataGridView after editing
                dataGridViewTasks.DataSource = null;
                var tasksData = MainForm.Tasks.Select(t => new
                {
                    Tytul = t.Title,
                    Opis = t.Description,
                    TerminOddania = t.DueDate.ToString("dd.MM.yyyy HH:mm"),
                    RozwiazanieNauczyciela = t.TeacherSolution,
                    RozwiazanieUcznia = t.StudentSolution,
                    DataWyslania = t.SubmissionDate.HasValue ? t.SubmissionDate.Value.ToString("dd.MM.yyyy HH:mm") : "Nie wysłano"
                }).ToList();
                dataGridViewTasks.DataSource = tasksData;

                // Set column headers to Polish
                dataGridViewTasks.Columns["Tytul"].HeaderText = "Tytuł";
                dataGridViewTasks.Columns["Opis"].HeaderText = "Opis";
                dataGridViewTasks.Columns["TerminOddania"].HeaderText = "Termin oddania";
                dataGridViewTasks.Columns["RozwiazanieNauczyciela"].HeaderText = "Rozwiązanie nauczyciela";
                dataGridViewTasks.Columns["RozwiazanieUcznia"].HeaderText = "Rozwiązanie ucznia";
                dataGridViewTasks.Columns["DataWyslania"].HeaderText = "Data wysłania";
            }
            else if (e.ColumnIndex == dataGridViewTasks.Columns["deleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                var task = MainForm.Tasks[e.RowIndex];
                var result = MessageBox.Show($"Na pewno chcesz usunąć zadanie '{task.Title}'?", "Usuń zadanie", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MainForm.Tasks.Remove(task);

                    // Refresh the DataGridView after deleting
                    dataGridViewTasks.DataSource = null;
                    var tasksData = MainForm.Tasks.Select(t => new
                    {
                        Tytul = t.Title,
                        Opis = t.Description,
                        TerminOddania = t.DueDate.ToString("dd.MM.yyyy HH:mm"),
                        RozwiazanieNauczyciela = t.TeacherSolution,
                        RozwiazanieUcznia = t.StudentSolution,
                        DataWyslania = t.SubmissionDate.HasValue ? t.SubmissionDate.Value.ToString("dd.MM.yyyy HH:mm") : "Nie wysłano"
                    }).ToList();
                    dataGridViewTasks.DataSource = tasksData;

                    // Set column headers to Polish
                    dataGridViewTasks.Columns["Tytul"].HeaderText = "Tytuł";
                    dataGridViewTasks.Columns["Opis"].HeaderText = "Opis";
                    dataGridViewTasks.Columns["TerminOddania"].HeaderText = "Termin oddania";
                    dataGridViewTasks.Columns["RozwiazanieNauczyciela"].HeaderText = "Rozwiązanie nauczyciela";
                    dataGridViewTasks.Columns["RozwiazanieUcznia"].HeaderText = "Rozwiązanie ucznia";
                    dataGridViewTasks.Columns["DataWyslania"].HeaderText = "Data wysłania";
                }
            }
            else if (e.ColumnIndex == dataGridViewTasks.Columns["viewSolutionButtonColumn"].Index && e.RowIndex >= 0)
            {
                var task = MainForm.Tasks[e.RowIndex];
                MessageBox.Show($"Rozwiązanie nauczyciela: {task.TeacherSolution}\nRozwiązanie ucznia: {task.StudentSolution}", "Rozwiązania");
            }
        }

        private void DataGridViewTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dataGridViewTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                using (var form = new LargeTextBoxForm(cellValue))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dataGridViewTasks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = form.EnteredText;
                    }
                }
            }
        }

        private DataGridView dataGridViewTasks;
        private DataGridViewButtonColumn editButtonColumn;
        private DataGridViewButtonColumn deleteButtonColumn;
        private DataGridViewButtonColumn viewSolutionButtonColumn;
    }
}
