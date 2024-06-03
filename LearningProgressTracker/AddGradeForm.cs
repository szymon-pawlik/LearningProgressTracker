// AddGradeForm.cs
using System;
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
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(12, 15);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(31, 13);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Task";
            // 
            // comboBoxTask
            // 
            this.comboBoxTask.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxTask.FormattingEnabled = true;
            this.comboBoxTask.Location = new System.Drawing.Point(80, 12);
            this.comboBoxTask.Name = "comboBoxTask";
            this.comboBoxTask.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTask.TabIndex = 1;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 42);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score";
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Location = new System.Drawing.Point(80, 40);
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownScore.TabIndex = 3;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(12, 68);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(56, 13);
            this.labelComments.TabIndex = 4;
            this.labelComments.Text = "Comments";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(80, 65);
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(200, 20);
            this.textBoxComments.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(80, 91);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);
            // 
            // AddGradeForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 126);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.numericUpDownScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.comboBoxTask);
            this.Controls.Add(this.labelTask);
            this.Name = "AddGradeForm";
            this.Text = "Add Grade";
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
            // Save the grade to a list or database
            string taskTitle = comboBoxTask.SelectedItem.ToString();
            int score = (int)numericUpDownScore.Value;
            string comments = textBoxComments.Text;

            // Example: Add to a static list (in real scenario, you might save to a database)
            MainForm.Grades.Add(new Grade(taskTitle, score, comments));

            MessageBox.Show("Grade added successfully");
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
