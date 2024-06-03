using System;
using System.Drawing;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class EditTaskForm : Form
    {
        private Task _task;

        public EditTaskForm(Task task)
        {
            _task = task;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTitle = new Label();
            this.textBoxTitle = new TextBox();
            this.labelDescription = new Label();
            this.textBoxDescription = new TextBox();
            this.labelDueDate = new Label();
            this.textBoxDueDate = new PlaceholderTextBox();
            this.labelDueTime = new Label();
            this.textBoxDueTime = new PlaceholderTextBox();
            this.labelSolution = new Label();
            this.textBoxSolution = new TextBox();
            this.buttonSave = new Button();
            this.SuspendLayout();
            // 
            // Form properties
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.BackColor = Color.FromArgb(240, 240, 240); 
            this.Text = "Edytuj zadanie";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tytuł";
            this.labelTitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelTitle.ForeColor = Color.FromArgb(70, 70, 70); // Dark grey text
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(150, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(180, 23);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = _task.Title;
            this.textBoxTitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(28, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Opis";
            this.labelDescription.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelDescription.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(150, 52);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(180, 40);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.Text = _task.Description;
            this.textBoxDescription.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(12, 105);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(70, 13);
            this.labelDueDate.TabIndex = 4;
            this.labelDueDate.Text = "Termin oddania";
            this.labelDueDate.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelDueDate.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // textBoxDueDate
            // 
            this.textBoxDueDate.Location = new System.Drawing.Point(150, 102);
            this.textBoxDueDate.Name = "textBoxDueDate";
            this.textBoxDueDate.Size = new System.Drawing.Size(180, 23);
            this.textBoxDueDate.TabIndex = 5;
            this.textBoxDueDate.Text = _task.DueDate.ToString("dd/MM/yyyy");
            this.textBoxDueDate.PlaceholderText = "DD/MM/YYYY";
            this.textBoxDueDate.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // labelDueTime
            // 
            this.labelDueTime.AutoSize = true;
            this.labelDueTime.Location = new System.Drawing.Point(12, 145);
            this.labelDueTime.Name = "labelDueTime";
            this.labelDueTime.Size = new System.Drawing.Size(42, 13);
            this.labelDueTime.TabIndex = 6;
            this.labelDueTime.Text = "Godzina";
            this.labelDueTime.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelDueTime.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // textBoxDueTime
            // 
            this.textBoxDueTime.Location = new System.Drawing.Point(150, 142);
            this.textBoxDueTime.Name = "textBoxDueTime";
            this.textBoxDueTime.Size = new System.Drawing.Size(180, 23);
            this.textBoxDueTime.TabIndex = 7;
            this.textBoxDueTime.Text = _task.DueDate.ToString("HH:mm");
            this.textBoxDueTime.PlaceholderText = "HH:MM";
            this.textBoxDueTime.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(12, 185);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(62, 13);
            this.labelSolution.TabIndex = 8;
            this.labelSolution.Text = "Rozwiązanie";
            this.labelSolution.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelSolution.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(150, 182);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(180, 23);
            this.textBoxSolution.TabIndex = 9;
            this.textBoxSolution.Text = _task.TeacherSolution;
            this.textBoxSolution.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 30);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.BackColor = Color.FromArgb(0, 120, 215);
            this.buttonSave.FlatStyle = FlatStyle.Flat;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);
            // 
            // EditTaskForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSolution);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.textBoxDueTime);
            this.Controls.Add(this.labelDueTime);
            this.Controls.Add(this.textBoxDueDate);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "EditTaskForm";
            this.Text = "Edytuj zadanie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _task.Title = textBoxTitle.Text;
            _task.Description = textBoxDescription.Text;
            DateTime dueDate;
            if (!DateTime.TryParseExact(textBoxDueDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dueDate))
            {
                MessageBox.Show("Proszę wpisać prawidłową datę w formacie DD/MM/RRRR.");
                return;
            }

            TimeSpan dueTime;
            if (!TimeSpan.TryParse(textBoxDueTime.Text, out dueTime))
            {
                MessageBox.Show("Proszę wpisać prawidłową godzinę w formacie HH:MM.");
                return;
            }

            dueDate = dueDate.Add(dueTime);
            _task.DueDate = dueDate;
            _task.TeacherSolution = textBoxSolution.Text;

            MessageBox.Show("Zadanie zmieniono prawidłowo");
            this.Close();
        }

        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelDueDate;
        private PlaceholderTextBox textBoxDueDate;
        private Label labelDueTime;
        private PlaceholderTextBox textBoxDueTime;
        private Label labelSolution;
        private TextBox textBoxSolution;
        private Button buttonSave;
    }
}