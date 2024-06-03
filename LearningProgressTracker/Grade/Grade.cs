using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProgressTracker
{
    public class Grade
    {
        public string TaskTitle { get; set; }
        public int Score { get; set; }
        public string Comments { get; set; }

        public Grade(string taskTitle, int score, string comments)
        {
            TaskTitle = taskTitle;
            Score = score;
            Comments = comments;
        }
    }
}
