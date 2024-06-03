using System;
using System.Linq;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class SelectTaskForm : Form
    {
        public Task SelectedTask { get; private set; }

        public SelectTaskForm()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void InitializeComponent()
        {
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 15;
            this.listBoxTasks.Location = new System.Drawing.Point(12, 12);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(360, 304);
            this.listBoxTasks.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(297, 322);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Wybierz";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // SelectTaskForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "SelectTaskForm";
            this.Text = "Wybierz Zadanie";
            this.ResumeLayout(false);
        }

        private void LoadTasks()
        {
            listBoxTasks.DataSource = MainForm.Tasks.Where(t => !t.IsCompleted).ToList();
            listBoxTasks.DisplayMember = "Title";
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            SelectedTask = listBoxTasks.SelectedItem as Task;
            if (SelectedTask != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Proszę wybrać zadanie.");
            }
        }

        private ListBox listBoxTasks;
        private Button buttonSelect;
    }
}
