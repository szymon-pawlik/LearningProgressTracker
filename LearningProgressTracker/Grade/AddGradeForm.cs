using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class AddGradeForm : Form
    {
        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTask = new Label();
            this.comboBoxTask = new ComboBox();
            this.labelScore = new Label();
            this.numericUpDownScore = new NumericUpDown();
            this.labelComments = new Label();
            this.textBoxComments = new TextBox();
            this.buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).BeginInit();
            this.SuspendLayout();
            // 
            // Form properties
            // 
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Dodaj Ocene";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(12, 20);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(42, 15);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Zadanie";
            this.labelTask.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelTask.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Location = new System.Drawing.Point(120, 18);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(180, 23);
            this.comboBoxTask.TabIndex = 1;
            this.comboBoxTask.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 60);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(38, 15);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Wynik";
            this.labelScore.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelScore.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.DecimalPlaces = 1;
            this.numericUpDownScore.Increment = 0.5M;
            this.numericUpDownScore.Minimum = 2.0M;
            this.numericUpDownScore.Maximum = 5.0M;
            this.numericUpDownScore.Location = new System.Drawing.Point(120, 58);
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(180, 23);
            this.numericUpDownScore.TabIndex = 3;
            this.numericUpDownScore.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(12, 100);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(72, 15);
            this.labelComments.TabIndex = 4;
            this.labelComments.Text = "Komentarz";
            this.labelComments.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.labelComments.ForeColor = Color.FromArgb(70, 70, 70);
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(120, 98);
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(180, 23);
            this.textBoxComments.TabIndex = 5;
            this.textBoxComments.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(120, 138);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 30);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.buttonSave.ForeColor = Color.White;
            this.buttonSave.BackColor = Color.FromArgb(0, 120, 215);
            this.buttonSave.FlatStyle = FlatStyle.Flat;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);
            // 
            // AddGradeForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 180);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.numericUpDownScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.comboBoxTask);
            this.Controls.Add(this.labelTask);
            this.Name = "AddGradeForm";
            this.Text = "Dodaj Ocene";
            this.Load += new EventHandler(this.AddGradeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            // Load tasks into ComboBox
            comboBoxTask.DataSource = MainForm.Tasks.Select(t => t.Title).ToList();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTask.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać zadanie");
                return;
            }

            string taskTitle = comboBoxTask.SelectedItem.ToString();
            decimal score = numericUpDownScore.Value;
            string comments = textBoxComments.Text;

            MainForm.Grades.Add(new Grade(taskTitle, (int)(score * 10), comments));

            MessageBox.Show("Ocena dodana prawidłowo");
            this.Close();
        }

        private Label labelTask;
        private ComboBox comboBoxTask;
        private Label labelScore;
        private NumericUpDown numericUpDownScore;
        private Label labelComments;
        private TextBox textBoxComments;
        private Button buttonSave;
    }
}
