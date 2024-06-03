using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public partial class MainForm : Form
    {
        public static List<Task> Tasks = new List<Task>();
        public static List<Grade> Grades = new List<Grade>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solveTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.labelCurrentTasks = new System.Windows.Forms.Label();
            this.labelTasksSolved = new System.Windows.Forms.Label();
            this.labelAssessedTasks = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Pasek menu";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.viewTasksToolStripMenuItem,
            this.solveTaskToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tasksToolStripMenuItem.Text = "Zadania";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addTaskToolStripMenuItem.Text = "Dodaj zadanie";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.AddTaskToolStripMenuItem_Click);
            // 
            // viewTasksToolStripMenuItem
            // 
            this.viewTasksToolStripMenuItem.Name = "viewTasksToolStripMenuItem";
            this.viewTasksToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewTasksToolStripMenuItem.Text = "Wyświetl zadania";
            this.viewTasksToolStripMenuItem.Click += new System.EventHandler(this.ViewTasksToolStripMenuItem_Click);
            // 
            // solveTaskToolStripMenuItem
            // 
            this.solveTaskToolStripMenuItem.Name = "solveTaskToolStripMenuItem";
            this.solveTaskToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.solveTaskToolStripMenuItem.Text = "Rozwiąż zadania";
            this.solveTaskToolStripMenuItem.Click += new System.EventHandler(this.SolveTaskToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGradeToolStripMenuItem,
            this.viewReportToolStripMenuItem});
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gradesToolStripMenuItem.Text = "Oceny";
            // 
            // addGradeToolStripMenuItem
            // 
            this.addGradeToolStripMenuItem.Name = "addGradeToolStripMenuItem";
            this.addGradeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addGradeToolStripMenuItem.Text = "Dodaj ocenę";
            this.addGradeToolStripMenuItem.Click += new System.EventHandler(this.AddGradeToolStripMenuItem_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.viewReportToolStripMenuItem.Text = "Zobacz raport";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.ViewReportToolStripMenuItem_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.labelCurrentDate);
            this.infoPanel.Controls.Add(this.labelCurrentTasks);
            this.infoPanel.Controls.Add(this.labelTasksSolved);
            this.infoPanel.Controls.Add(this.labelAssessedTasks);
            this.infoPanel.Location = new System.Drawing.Point(150, 100);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(500, 300);
            this.infoPanel.BackColor = Color.FromArgb(40, 40, 40);
            this.infoPanel.TabIndex = 1;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.labelCurrentDate.ForeColor = Color.White;
            this.labelCurrentDate.Location = new Point(50, 50);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(180, 21);
            this.labelCurrentDate.TabIndex = 0;
            this.labelCurrentDate.Text = "Dzisiejsza data: " + DateTime.Now.ToString("dd MMMM yyyy");
            // 
            // labelCurrentTasks
            // 
            this.labelCurrentTasks.AutoSize = true;
            this.labelCurrentTasks.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.labelCurrentTasks.ForeColor = Color.White;
            this.labelCurrentTasks.Location = new Point(50, 100);
            this.labelCurrentTasks.Name = "labelCurrentTasks";
            this.labelCurrentTasks.Size = new System.Drawing.Size(154, 21);
            this.labelCurrentTasks.TabIndex = 1;
            this.labelCurrentTasks.Text = "Obecne zadania: " + Tasks.Count(t => !t.IsCompleted).ToString();
            // 
            // labelTasksSolved
            // 
            this.labelTasksSolved.AutoSize = true;
            this.labelTasksSolved.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.labelTasksSolved.ForeColor = Color.White;
            this.labelTasksSolved.Location = new Point(50, 150);
            this.labelTasksSolved.Name = "labelTasksSolved";
            this.labelTasksSolved.Size = new System.Drawing.Size(173, 21);
            this.labelTasksSolved.TabIndex = 2;
            this.labelTasksSolved.Text = "Rozwiązane zadania: " + Tasks.Count(t => t.IsCompleted).ToString();
            // 
            // labelAssessedTasks
            // 
            this.labelAssessedTasks.AutoSize = true;
            this.labelAssessedTasks.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.labelAssessedTasks.ForeColor = Color.White;
            this.labelAssessedTasks.Location = new Point(50, 200);
            this.labelAssessedTasks.Name = "labelAssessedTasks";
            this.labelAssessedTasks.Size = new System.Drawing.Size(169, 21);
            this.labelAssessedTasks.TabIndex = 3;
            this.labelAssessedTasks.Text = "Ocenione zadania: " + Grades.Count.ToString();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "System do śledzenia postępów w nauce";
            this.BackColor = Color.Black;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AddTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
            UpdateInfoPanel();
        }

        private void ViewTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tasks.Count == 0)
            {
                MessageBox.Show("Nie ma żadnych zadań do wyświetlenia.", "Brak zadań");
                return;
            }
            var viewTasksForm = new ViewTasksForm();
            viewTasksForm.ShowDialog();
            UpdateInfoPanel();
        }

        private void SolveTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectTaskForm = new SelectTaskForm();
            if (selectTaskForm.ShowDialog() == DialogResult.OK)
            {
                var selectedTask = selectTaskForm.SelectedTask;
                if (selectedTask != null)
                {
                    var solveTaskForm = new SolveTaskForm(selectedTask);
                    solveTaskForm.ShowDialog();
                    UpdateInfoPanel();
                }
            }
        }

        private void AddGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addGradeForm = new AddGradeForm();
            addGradeForm.ShowDialog();
            UpdateInfoPanel();
        }

        private void ViewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Grades.Count == 0)
            {
                MessageBox.Show("Nie ma żadnych ocen do wyświetlenia.", "Brak ocen");
                return;
            }
            var viewReportForm = new ViewReportForm();
            viewReportForm.ShowDialog();
            UpdateInfoPanel();
        }

        private void UpdateInfoPanel()
        {
            labelCurrentDate.Text = "Dzisiejsza data: " + DateTime.Now.ToString("dd MMMM yyyy");
            labelCurrentTasks.Text = "Obecne zadania: " + Tasks.Count(t => !t.IsCompleted).ToString();
            labelTasksSolved.Text = "Rozwiązane zadania: " + Tasks.Count(t => t.IsCompleted).ToString();
            labelAssessedTasks.Text = "Ocenione zadania: " + Grades.Count.ToString();
        }

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solveTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Label labelCurrentTasks;
        private System.Windows.Forms.Label labelTasksSolved;
        private System.Windows.Forms.Label labelAssessedTasks;
    }
}
