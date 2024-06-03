using System;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class EditGradeForm : Form
    {
        private Grade _grade;

        public EditGradeForm(Grade grade)
        {
            _grade = grade;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelTask = new Label();
            this.textBoxTask = new TextBox();
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
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(80, 12);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(200, 20);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = _grade.TaskTitle;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 41);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score";
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Location = new System.Drawing.Point(80, 39);
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownScore.TabIndex = 3;
            this.numericUpDownScore.Value = _grade.Score;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(12, 67);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(56, 13);
            this.labelComments.TabIndex = 4;
            this.labelComments.Text = "Comments";
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(80, 64);
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(200, 20);
            this.textBoxComments.TabIndex = 5;
            this.textBoxComments.Text = _grade.Comments;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(80, 90);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);
            // 
            // EditGradeForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 125);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.numericUpDownScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.labelTask);
            this.Name = "EditGradeForm";
            this.Text = "Edit Grade";
            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Save the edited grade
            _grade.Score = (int)numericUpDownScore.Value;
            _grade.Comments = textBoxComments.Text;

            MessageBox.Show("Grade updated successfully");
            this.Close();
        }

        private Label labelTask;
        private TextBox textBoxTask;
        private Label labelScore;
        private NumericUpDown numericUpDownScore;
        private Label labelComments;
        private TextBox textBoxComments;
        private Button buttonSave;
    }
}
