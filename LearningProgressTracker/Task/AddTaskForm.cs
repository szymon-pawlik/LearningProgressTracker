using System;
using System.Drawing;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.textBoxDueDate = new LearningProgressTracker.PlaceholderTextBox();
            this.labelDueTime = new System.Windows.Forms.Label();
            this.textBoxDueTime = new LearningProgressTracker.PlaceholderTextBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTitle.Location = new System.Drawing.Point(10, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 19);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tytuł";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTitle.Location = new System.Drawing.Point(150, 15);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(360, 93);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelDescription.Location = new System.Drawing.Point(12, 114);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(37, 19);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Opis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDescription.Location = new System.Drawing.Point(150, 114);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(360, 80);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.DoubleClick += new System.EventHandler(this.TextBoxDescription_DoubleClick);
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelDueDate.Location = new System.Drawing.Point(12, 200);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(103, 19);
            this.labelDueDate.TabIndex = 4;
            this.labelDueDate.Text = "Termin oddania";
            // 
            // textBoxDueDate
            // 
            this.textBoxDueDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDueDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxDueDate.Location = new System.Drawing.Point(150, 200);
            this.textBoxDueDate.Name = "textBoxDueDate";
            this.textBoxDueDate.PlaceholderText = "DD/MM/YYYY";
            this.textBoxDueDate.Size = new System.Drawing.Size(360, 25);
            this.textBoxDueDate.TabIndex = 5;
            this.textBoxDueDate.Text = "DD/MM/YYYY";
            // 
            // labelDueTime
            // 
            this.labelDueTime.AutoSize = true;
            this.labelDueTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDueTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelDueTime.Location = new System.Drawing.Point(12, 231);
            this.labelDueTime.Name = "labelDueTime";
            this.labelDueTime.Size = new System.Drawing.Size(59, 19);
            this.labelDueTime.TabIndex = 6;
            this.labelDueTime.Text = "Godzina";
            // 
            // textBoxDueTime
            // 
            this.textBoxDueTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxDueTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxDueTime.Location = new System.Drawing.Point(150, 231);
            this.textBoxDueTime.Name = "textBoxDueTime";
            this.textBoxDueTime.PlaceholderText = "HH:MM";
            this.textBoxDueTime.Size = new System.Drawing.Size(360, 25);
            this.textBoxDueTime.TabIndex = 7;
            this.textBoxDueTime.Text = "HH:MM";
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelSolution.Location = new System.Drawing.Point(10, 262);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(82, 19);
            this.labelSolution.TabIndex = 8;
            this.labelSolution.Text = "Rozwiązanie";
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSolution.Location = new System.Drawing.Point(150, 262);
            this.textBoxSolution.Multiline = true;
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(360, 80);
            this.textBoxSolution.TabIndex = 9;
            this.textBoxSolution.DoubleClick += new System.EventHandler(this.TextBoxSolution_DoubleClick);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(150, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(360, 40);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // AddTaskForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
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
            this.Name = "AddTaskForm";
            this.Text = "Dodaj Zadanie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void TextBoxDescription_DoubleClick(object sender, EventArgs e)
        {
            using (var textInputForm = new LargeTextBoxForm(textBoxDescription.Text))
            {
                if (textInputForm.ShowDialog() == DialogResult.OK)
                {
                    textBoxDescription.Text = textInputForm.EnteredText; // Use the correct property
                }
            }
        }

        private void TextBoxSolution_DoubleClick(object sender, EventArgs e)
        {
            using (var textInputForm = new LargeTextBoxForm(textBoxSolution.Text))
            {
                if (textInputForm.ShowDialog() == DialogResult.OK)
                {
                    textBoxSolution.Text = textInputForm.EnteredText; // Use the correct property
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Validate and save the new task
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            DateTime dueDate;
            if (!DateTime.TryParseExact(textBoxDueDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dueDate))
            {
                MessageBox.Show("Proszę wpisać prawidłową datę w formacie DD/MM/RRRR.");
                return;
            }

            if (dueDate < DateTime.Today)
            {
                MessageBox.Show("Termin oddania nie może być datą przeszłą.");
                return;
            }

            TimeSpan dueTime;
            if (!TimeSpan.TryParse(textBoxDueTime.Text, out dueTime))
            {
                MessageBox.Show("Proszę wpisać prawidłową godzinę w formacie HH:MM.");
                return;
            }

            dueDate = dueDate.Add(dueTime);
            string solution = textBoxSolution.Text;

            MainForm.Tasks.Add(new Task(title, description, dueDate, solution));

            MessageBox.Show("Zadanie dodano prawidłowo");
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
