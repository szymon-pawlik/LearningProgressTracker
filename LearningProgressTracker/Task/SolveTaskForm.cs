using System;
using System.Drawing;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class SolveTaskForm : Form
    {
        private Task task;

        public SolveTaskForm(Task task)
        {
            InitializeComponent();
            this.task = task;
            textBoxDescription.Text = task.Description;
        }

        private void InitializeComponent()
        {
            this.labelDescription = new Label();
            this.textBoxDescription = new TextBox();
            this.labelSolution = new Label();
            this.textBoxSolution = new TextBox();
            this.buttonSubmit = new Button();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new Font("Segoe UI", 10F);
            this.labelDescription.ForeColor = Color.FromArgb(70, 70, 70);
            this.labelDescription.Location = new Point(12, 18);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new Size(37, 19);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Opis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new Font("Segoe UI", 10F);
            this.textBoxDescription.Location = new Point(150, 15);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new Size(360, 80);
            this.textBoxDescription.TabIndex = 1;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Font = new Font("Segoe UI", 10F);
            this.labelSolution.ForeColor = Color.FromArgb(70, 70, 70);
            this.labelSolution.Location = new Point(12, 110);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new Size(82, 19);
            this.labelSolution.TabIndex = 2;
            this.labelSolution.Text = "Rozwiązanie";
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Font = new Font("Segoe UI", 10F);
            this.textBoxSolution.Location = new Point(150, 110);
            this.textBoxSolution.Multiline = true;
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new Size(360, 80);
            this.textBoxSolution.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = Color.FromArgb(0, 120, 215);
            this.buttonSubmit.FlatStyle = FlatStyle.Flat;
            this.buttonSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.buttonSubmit.ForeColor = Color.White;
            this.buttonSubmit.Location = new Point(150, 200);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new Size(360, 40);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Zapisz";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new EventHandler(this.ButtonSubmit_Click);
            // 
            // SolveTaskForm
            // 
            this.ClientSize = new Size(550, 270);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxSolution);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Name = "SolveTaskForm";
            this.Text = "Rozwiąż Zadanie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > task.DueDate)
            {
                MessageBox.Show("Nie można wysłać rozwiązania po terminie oddania.", "Termin minął", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            task.StudentSolution = textBoxSolution.Text;
            task.IsCompleted = true;
            task.SubmissionDate = DateTime.Now;

            MessageBox.Show("Rozwiązanie zostało zapisane");
            this.Close();
        }

        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelSolution;
        private TextBox textBoxSolution;
        private Button buttonSubmit;
    }
}
