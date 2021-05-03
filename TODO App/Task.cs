using System;
using System.Collections.Generic;
using System.Text;

namespace TODO_App
{
    class Task
    {
        private string taskDescription;
        private DateTime taskDate;
        private int taskPriority;

        enum priorities {
            Low, Medium, High
        }

        public Task()
        {
        }

        public Task(string taskDescription, DateTime taskDate, int taskPriority)
        {
            this.taskDescription = taskDescription;
            this.taskDate = taskDate;
            this.taskPriority = taskPriority;
        }

        public override string ToString()
        {
            return taskDescription + "," + taskDate + "," + taskPriority;
        }
    }
}