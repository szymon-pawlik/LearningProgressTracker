using System;
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
            this.labelTitle = new Label();
            this.textBoxTitle = new TextBox();
            this.labelDescription = new Label();
            this.textBoxDescription = new TextBox();
            this.labelDueDate = new Label();
            this.dateTimePickerDueDate = new DateTimePicker();
            this.labelSolution = new Label();
            this.textBoxSolution = new TextBox();
            this.buttonSave = new Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(80, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 41);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(80, 38);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 3;
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(12, 67);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(52, 13);
            this.labelDueDate.TabIndex = 4;
            this.labelDueDate.Text = "Due Date";
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(80, 64);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDueDate.TabIndex = 5;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(12, 93);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(45, 13);
            this.labelSolution.TabIndex = 6;
            this.labelSolution.Text = "Solution";
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(80, 90);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(200, 20);
            this.textBoxSolution.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(80, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.ButtonSave_Click);
            // 
            // AddTaskForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 151);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSolution);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddTaskForm";
            this.Text = "Add Task";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            // Save the task to a list or database
            string title = textBoxTitle.Text;
            string description = textBoxDescription.Text;
            DateTime dueDate = dateTimePickerDueDate.Value;
            string solution = textBoxSolution.Text;

            // Example: Add to a static list (in real scenario, you might save to a database)
            MainForm.Tasks.Add(new Task(title, description, dueDate) { Solution = solution });

            MessageBox.Show("Task added successfully");
            this.Close();
        }

        private Label labelTitle;
        private TextBox textBoxTitle;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelDueDate;
        private DateTimePicker dateTimePickerDueDate;
        private Label labelSolution;
        private TextBox textBoxSolution;
        private Button buttonSave;
    }
}