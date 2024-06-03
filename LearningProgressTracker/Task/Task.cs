using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LearningProgressTracker
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string TeacherSolution { get; set; }
        public string StudentSolution { get; set; }
        public DateTime? SubmissionDate { get; set; }

        public Task(string title, string description, DateTime dueDate, string teacherSolution)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            TeacherSolution = teacherSolution;
            IsCompleted = false;
            StudentSolution = string.Empty;
        }

        public void SetSolution(string solution)
        {
            StudentSolution = solution;
            IsCompleted = true;
            SubmissionDate = DateTime.Now;
        }
    }

    public class PlaceholderTextBox : TextBox
    {
        private string _placeholderText;
        private bool _isPlaceholderActive;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The text that is displayed when the control is empty and not focused.")]
        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                UpdatePlaceholder();
            }
        }

        public PlaceholderTextBox()
        {
            _isPlaceholderActive = true;
            GotFocus += RemovePlaceholder;
            LostFocus += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (_isPlaceholderActive)
            {
                _isPlaceholderActive = false;
                Text = "";
                ForeColor = SystemColors.WindowText;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                _isPlaceholderActive = true;
                UpdatePlaceholder();
            }
        }

        private void UpdatePlaceholder()
        {
            if (_isPlaceholderActive && !string.IsNullOrEmpty(_placeholderText))
            {
                Text = _placeholderText;
                ForeColor = SystemColors.GrayText;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetPlaceholder(null, null);
        }
    }
}
