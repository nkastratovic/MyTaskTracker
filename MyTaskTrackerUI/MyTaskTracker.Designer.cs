namespace MyTaskTrackerUI
{
    partial class MyTaskTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lstNewTasks = new System.Windows.Forms.ListBox();
            this.lstTasksInProcess = new System.Windows.Forms.ListBox();
            this.lstTasksDone = new System.Windows.Forms.ListBox();
            this.btnMoveToInProcess = new System.Windows.Forms.Button();
            this.btnMoveToDone = new System.Windows.Forms.Button();
            this.btnReturnToTasksInProcess = new System.Windows.Forms.Button();
            this.btnReturnToNewTasks = new System.Windows.Forms.Button();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.lblNewTask = new System.Windows.Forms.Label();
            this.lblTaskInProcess = new System.Windows.Forms.Label();
            this.lblTaskDone = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnTaskUpdate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTaskStatus = new System.Windows.Forms.TextBox();
            this.txtTaskDelete = new System.Windows.Forms.Button();
            this.lblTaskMastHaveName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lstNewTasks
            // 
            this.lstNewTasks.FormattingEnabled = true;
            this.lstNewTasks.Location = new System.Drawing.Point(12, 25);
            this.lstNewTasks.Name = "lstNewTasks";
            this.lstNewTasks.Size = new System.Drawing.Size(210, 212);
            this.lstNewTasks.TabIndex = 0;
            this.lstNewTasks.Click += new System.EventHandler(this.LstNewTasks_Click);
            // 
            // lstTasksInProcess
            // 
            this.lstTasksInProcess.FormattingEnabled = true;
            this.lstTasksInProcess.Location = new System.Drawing.Point(300, 25);
            this.lstTasksInProcess.Name = "lstTasksInProcess";
            this.lstTasksInProcess.Size = new System.Drawing.Size(210, 212);
            this.lstTasksInProcess.TabIndex = 1;
            this.lstTasksInProcess.Click += new System.EventHandler(this.LstTasksInProcess_Click);
            this.lstTasksInProcess.SelectedIndexChanged += new System.EventHandler(this.LstTasksInProcess_SelectedIndexChanged);
            // 
            // lstTasksDone
            // 
            this.lstTasksDone.FormattingEnabled = true;
            this.lstTasksDone.Location = new System.Drawing.Point(591, 25);
            this.lstTasksDone.Name = "lstTasksDone";
            this.lstTasksDone.Size = new System.Drawing.Size(210, 212);
            this.lstTasksDone.TabIndex = 2;
            this.lstTasksDone.Click += new System.EventHandler(this.LstTasksDone_Click);
            this.lstTasksDone.SelectedIndexChanged += new System.EventHandler(this.LstTasksDone_SelectedIndexChanged);
            // 
            // btnMoveToInProcess
            // 
            this.btnMoveToInProcess.Location = new System.Drawing.Point(228, 143);
            this.btnMoveToInProcess.Name = "btnMoveToInProcess";
            this.btnMoveToInProcess.Size = new System.Drawing.Size(66, 23);
            this.btnMoveToInProcess.TabIndex = 3;
            this.btnMoveToInProcess.Text = ">>";
            this.btnMoveToInProcess.UseVisualStyleBackColor = true;
            this.btnMoveToInProcess.Click += new System.EventHandler(this.btnMoveToInProcess_Click);
            // 
            // btnMoveToDone
            // 
            this.btnMoveToDone.Location = new System.Drawing.Point(519, 143);
            this.btnMoveToDone.Name = "btnMoveToDone";
            this.btnMoveToDone.Size = new System.Drawing.Size(66, 23);
            this.btnMoveToDone.TabIndex = 4;
            this.btnMoveToDone.Text = ">>";
            this.btnMoveToDone.UseVisualStyleBackColor = true;
            this.btnMoveToDone.Click += new System.EventHandler(this.btnMoveToDone_Click);
            // 
            // btnReturnToTasksInProcess
            // 
            this.btnReturnToTasksInProcess.Location = new System.Drawing.Point(519, 172);
            this.btnReturnToTasksInProcess.Name = "btnReturnToTasksInProcess";
            this.btnReturnToTasksInProcess.Size = new System.Drawing.Size(66, 23);
            this.btnReturnToTasksInProcess.TabIndex = 5;
            this.btnReturnToTasksInProcess.Text = "<<";
            this.btnReturnToTasksInProcess.UseVisualStyleBackColor = true;
            this.btnReturnToTasksInProcess.Click += new System.EventHandler(this.btnReturnToTasksInProcess_Click);
            // 
            // btnReturnToNewTasks
            // 
            this.btnReturnToNewTasks.Location = new System.Drawing.Point(228, 172);
            this.btnReturnToNewTasks.Name = "btnReturnToNewTasks";
            this.btnReturnToNewTasks.Size = new System.Drawing.Size(66, 23);
            this.btnReturnToNewTasks.TabIndex = 6;
            this.btnReturnToNewTasks.Text = "<<";
            this.btnReturnToNewTasks.UseVisualStyleBackColor = true;
            this.btnReturnToNewTasks.Click += new System.EventHandler(this.btnReturnToNewTasks_Click);
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Location = new System.Drawing.Point(74, 429);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(66, 23);
            this.btnAddNewTask.TabIndex = 7;
            this.btnAddNewTask.Text = "Add";
            this.btnAddNewTask.UseVisualStyleBackColor = true;
            this.btnAddNewTask.Click += new System.EventHandler(this.BtnAddNewTask_Click);
            // 
            // lblNewTask
            // 
            this.lblNewTask.AutoSize = true;
            this.lblNewTask.Location = new System.Drawing.Point(12, 9);
            this.lblNewTask.Name = "lblNewTask";
            this.lblNewTask.Size = new System.Drawing.Size(56, 13);
            this.lblNewTask.TabIndex = 11;
            this.lblNewTask.Text = "New Task";
            this.lblNewTask.Click += new System.EventHandler(this.LblNewTask_Click);
            // 
            // lblTaskInProcess
            // 
            this.lblTaskInProcess.AutoSize = true;
            this.lblTaskInProcess.Location = new System.Drawing.Point(297, 9);
            this.lblTaskInProcess.Name = "lblTaskInProcess";
            this.lblTaskInProcess.Size = new System.Drawing.Size(57, 13);
            this.lblTaskInProcess.TabIndex = 12;
            this.lblTaskInProcess.Text = "In Process";
            // 
            // lblTaskDone
            // 
            this.lblTaskDone.AutoSize = true;
            this.lblTaskDone.Location = new System.Drawing.Point(588, 9);
            this.lblTaskDone.Name = "lblTaskDone";
            this.lblTaskDone.Size = new System.Drawing.Size(33, 13);
            this.lblTaskDone.TabIndex = 13;
            this.lblTaskDone.Text = "Done";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(735, 429);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(66, 23);
            this.btnCloseForm.TabIndex = 14;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(74, 259);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(40, 20);
            this.txtTaskId.TabIndex = 15;
            this.txtTaskId.Visible = false;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(75, 330);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(209, 93);
            this.txtTaskDescription.TabIndex = 16;
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(74, 293);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(210, 20);
            this.txtTaskTitle.TabIndex = 17;
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Location = new System.Drawing.Point(9, 262);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(19, 13);
            this.lblTaskId.TabIndex = 18;
            this.lblTaskId.Text = "Id:";
            this.lblTaskId.Visible = false;
            this.lblTaskId.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 296);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 335);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description:";
            // 
            // btnTaskUpdate
            // 
            this.btnTaskUpdate.Location = new System.Drawing.Point(146, 429);
            this.btnTaskUpdate.Name = "btnTaskUpdate";
            this.btnTaskUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnTaskUpdate.TabIndex = 21;
            this.btnTaskUpdate.Text = "Update";
            this.btnTaskUpdate.UseVisualStyleBackColor = true;
            this.btnTaskUpdate.Click += new System.EventHandler(this.BtnTaskUpdate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(179, 262);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "StatusId:";
            this.lblStatus.Visible = false;
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.Location = new System.Drawing.Point(244, 259);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.Size = new System.Drawing.Size(40, 20);
            this.txtTaskStatus.TabIndex = 22;
            this.txtTaskStatus.Visible = false;
            // 
            // txtTaskDelete
            // 
            this.txtTaskDelete.Location = new System.Drawing.Point(218, 429);
            this.txtTaskDelete.Name = "txtTaskDelete";
            this.txtTaskDelete.Size = new System.Drawing.Size(66, 23);
            this.txtTaskDelete.TabIndex = 24;
            this.txtTaskDelete.Text = "Delete";
            this.txtTaskDelete.UseVisualStyleBackColor = true;
            this.txtTaskDelete.Click += new System.EventHandler(this.TxtTaskDelete_Click);
            // 
            // lblTaskMastHaveName
            // 
            this.lblTaskMastHaveName.AutoSize = true;
            this.lblTaskMastHaveName.ForeColor = System.Drawing.Color.Red;
            this.lblTaskMastHaveName.Location = new System.Drawing.Point(290, 296);
            this.lblTaskMastHaveName.Name = "lblTaskMastHaveName";
            this.lblTaskMastHaveName.Size = new System.Drawing.Size(115, 13);
            this.lblTaskMastHaveName.TabIndex = 25;
            this.lblTaskMastHaveName.Text = "Task mast have name!";
            this.lblTaskMastHaveName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 215);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new task";
            // 
            // MyTaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 464);
            this.Controls.Add(this.lblTaskMastHaveName);
            this.Controls.Add(this.txtTaskDelete);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtTaskStatus);
            this.Controls.Add(this.btnTaskUpdate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTaskId);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblTaskDone);
            this.Controls.Add(this.lblTaskInProcess);
            this.Controls.Add(this.lblNewTask);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.btnReturnToNewTasks);
            this.Controls.Add(this.btnReturnToTasksInProcess);
            this.Controls.Add(this.btnMoveToDone);
            this.Controls.Add(this.btnMoveToInProcess);
            this.Controls.Add(this.lstTasksDone);
            this.Controls.Add(this.lstTasksInProcess);
            this.Controls.Add(this.lstNewTasks);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyTaskTracker";
            this.Text = "MyTaskTracker";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblTaskDone;
        private System.Windows.Forms.Label lblTaskInProcess;
        private System.Windows.Forms.Label lblNewTask;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Button btnReturnToNewTasks;
        private System.Windows.Forms.Button btnReturnToTasksInProcess;
        private System.Windows.Forms.Button btnMoveToDone;
        private System.Windows.Forms.Button btnMoveToInProcess;
        private System.Windows.Forms.ListBox lstTasksDone;
        private System.Windows.Forms.ListBox lstTasksInProcess;
        private System.Windows.Forms.ListBox lstNewTasks;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Button btnTaskUpdate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTaskStatus;
        private System.Windows.Forms.Button txtTaskDelete;
        private System.Windows.Forms.Label lblTaskMastHaveName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

