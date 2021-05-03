
namespace TODO_App
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.dtpDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTaskDateAndTime = new System.Windows.Forms.Label();
            this.lblTaskPriority = new System.Windows.Forms.Label();
            this.cmbTaskPriority = new System.Windows.Forms.ComboBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(150, 104);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(200, 23);
            this.txtTaskDescription.TabIndex = 2;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(38, 107);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(95, 15);
            this.lblTaskDescription.TabIndex = 7;
            this.lblTaskDescription.Text = "Task Description:";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(195, 375);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 12;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(337, 375);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 13;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(479, 375);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveTask.TabIndex = 14;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // dtpDateTimePicker
            // 
            this.dtpDateTimePicker.Location = new System.Drawing.Point(150, 186);
            this.dtpDateTimePicker.Name = "dtpDateTimePicker";
            this.dtpDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTimePicker.TabIndex = 15;
            // 
            // lblTaskDateAndTime
            // 
            this.lblTaskDateAndTime.AutoSize = true;
            this.lblTaskDateAndTime.Location = new System.Drawing.Point(38, 189);
            this.lblTaskDateAndTime.Name = "lblTaskDateAndTime";
            this.lblTaskDateAndTime.Size = new System.Drawing.Size(111, 15);
            this.lblTaskDateAndTime.TabIndex = 16;
            this.lblTaskDateAndTime.Text = "Task Date and Time:";
            // 
            // lblTaskPriority
            // 
            this.lblTaskPriority.AutoSize = true;
            this.lblTaskPriority.Location = new System.Drawing.Point(38, 271);
            this.lblTaskPriority.Name = "lblTaskPriority";
            this.lblTaskPriority.Size = new System.Drawing.Size(73, 15);
            this.lblTaskPriority.TabIndex = 18;
            this.lblTaskPriority.Text = "Task Priority:";
            // 
            // cmbTaskPriority
            // 
            this.cmbTaskPriority.FormattingEnabled = true;
            this.cmbTaskPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbTaskPriority.Location = new System.Drawing.Point(150, 268);
            this.cmbTaskPriority.Name = "cmbTaskPriority";
            this.cmbTaskPriority.Size = new System.Drawing.Size(200, 23);
            this.cmbTaskPriority.TabIndex = 19;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 15;
            this.lstTasks.Location = new System.Drawing.Point(400, 93);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(482, 214);
            this.lstTasks.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 419);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.cmbTaskPriority);
            this.Controls.Add(this.lblTaskPriority);
            this.Controls.Add(this.lblTaskDateAndTime);
            this.Controls.Add(this.dtpDateTimePicker);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.txtTaskDescription);
            this.Name = "frmMain";
            this.Text = "TODO";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Label lblTaskDateAndTime;
        private System.Windows.Forms.DateTimePicker dtpDateTimePicker;
        private System.Windows.Forms.Label lblTaskPriority;
        private System.Windows.Forms.ComboBox cmbTaskPriority;
        private System.Windows.Forms.ListBox lstTasks;
    }
}

