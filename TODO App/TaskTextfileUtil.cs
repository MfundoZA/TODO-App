using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TODO_App
{
    class TaskTextfileUtil
    {
        private static StreamWriter streamWriter;

        public static void Write(Task task)
        {
            try
            {
                streamWriter = new StreamWriter("Tasks.txt");
                streamWriter.WriteLine(task.ToString());
                streamWriter.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public static List<Task> Read()
        {
            List<Task> tasks = new List<Task>();

            try
            {
                string[] lines = System.IO.File.ReadAllLines("Tasks.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    StringBuilder temp = new StringBuilder(lines[i]);

                    string secondTemp = temp.ToString();

                    string[] taskValues = secondTemp.Split(',', StringSplitOptions.None);

                    string taskDescription = taskValues[1];
                    DateTime taskDateAndTime = new DateTime(Int64.Parse(taskValues[2]));
                    int taskPriority = Int16.Parse(taskValues[3]);

                    Task task = new Task(taskDescription, taskDateAndTime, taskPriority);

                    tasks.Add(task);
                }
            }
            catch (Exception exception)
            {
                //throw exception;
            }

            return tasks;
        }
    }
}
