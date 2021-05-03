using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_App
{
    public partial class frmMain : Form
    {
        string taskDescription;
        DateTime taskDateAndTime;
        int taskPriority;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtTaskDescription.Clear();
            dtpDateTimePicker.Value = DateTime.Today;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            taskDescription = txtTaskDescription.Text;
            taskDateAndTime = dtpDateTimePicker.Value;
            taskPriority = cmbTaskPriority.SelectedIndex;
            Task task = new Task(taskDescription, taskDateAndTime, taskPriority);

            lstTasks.Items.Add(taskDescription + "\t" + taskDateAndTime.Date + "\t" + cmbTaskPriority.SelectedItem);

            TaskListUtil.TaskList.Add(task);

            try
            {
                TaskTextfileUtil.Write(task);
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            lstTasks.SelectedItems.Clear();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            TaskListUtil.TaskList = TaskTextfileUtil.Read();

            lstTasks.Items.Add("Task Description \t" + "Task Date \t\t" + "Task Priority");

            for (int i = 0; i < TaskListUtil.TaskList.Count; i++)
            {
                lstTasks.Items.Add(taskDescription + "\t" + taskDateAndTime.Date + "\t\t" + cmbTaskPriority.SelectedItem);
            }
        }
    }
}
