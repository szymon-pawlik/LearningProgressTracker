using System;

namespace LearningProgressTracker
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string Solution { get; set; }

        public Task(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
            Solution = string.Empty;
        }

        public void SetSolution(string solution)
        {
            Solution = solution;
            IsCompleted = true;
        }
    }
}
