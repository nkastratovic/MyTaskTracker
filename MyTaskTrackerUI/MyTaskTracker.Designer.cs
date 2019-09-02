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
            this.btnDeleteFromNewTasks = new System.Windows.Forms.Button();
            this.btnDeleteFromInProcess = new System.Windows.Forms.Button();
            this.btnDeleteFromTasksDone = new System.Windows.Forms.Button();
            this.lblNewTask = new System.Windows.Forms.Label();
            this.lblTaskInProcess = new System.Windows.Forms.Label();
            this.lblTaskDone = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
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
            // 
            // lstTasksDone
            // 
            this.lstTasksDone.FormattingEnabled = true;
            this.lstTasksDone.Location = new System.Drawing.Point(591, 25);
            this.lstTasksDone.Name = "lstTasksDone";
            this.lstTasksDone.Size = new System.Drawing.Size(210, 212);
            this.lstTasksDone.TabIndex = 2;
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
            // btnDeleteFromNewTasks
            // 
            this.btnDeleteFromNewTasks.Location = new System.Drawing.Point(218, 429);
            this.btnDeleteFromNewTasks.Name = "btnDeleteFromNewTasks";
            this.btnDeleteFromNewTasks.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteFromNewTasks.TabIndex = 8;
            this.btnDeleteFromNewTasks.Text = "Delete";
            this.btnDeleteFromNewTasks.UseVisualStyleBackColor = true;
            this.btnDeleteFromNewTasks.Click += new System.EventHandler(this.btnDeleteFromNewTasks_Click);
            // 
            // btnDeleteFromInProcess
            // 
            this.btnDeleteFromInProcess.Location = new System.Drawing.Point(444, 273);
            this.btnDeleteFromInProcess.Name = "btnDeleteFromInProcess";
            this.btnDeleteFromInProcess.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteFromInProcess.TabIndex = 9;
            this.btnDeleteFromInProcess.Text = "Delete";
            this.btnDeleteFromInProcess.UseVisualStyleBackColor = true;
            this.btnDeleteFromInProcess.Click += new System.EventHandler(this.btnDeleteFromInProcess_Click);
            // 
            // btnDeleteFromTasksDone
            // 
            this.btnDeleteFromTasksDone.Location = new System.Drawing.Point(735, 273);
            this.btnDeleteFromTasksDone.Name = "btnDeleteFromTasksDone";
            this.btnDeleteFromTasksDone.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteFromTasksDone.TabIndex = 10;
            this.btnDeleteFromTasksDone.Text = "Delete";
            this.btnDeleteFromTasksDone.UseVisualStyleBackColor = true;
            this.btnDeleteFromTasksDone.Click += new System.EventHandler(this.BtnDeleteFromTasksDone_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(735, 330);
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
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 330);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(209, 93);
            this.txtDescription.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 293);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 17;
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Location = new System.Drawing.Point(9, 262);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(19, 13);
            this.lblTaskId.TabIndex = 18;
            this.lblTaskId.Text = "Id:";
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
            // MyTaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 464);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTaskId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblTaskDone);
            this.Controls.Add(this.lblTaskInProcess);
            this.Controls.Add(this.lblNewTask);
            this.Controls.Add(this.btnDeleteFromTasksDone);
            this.Controls.Add(this.btnDeleteFromInProcess);
            this.Controls.Add(this.btnDeleteFromNewTasks);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.btnReturnToNewTasks);
            this.Controls.Add(this.btnReturnToTasksInProcess);
            this.Controls.Add(this.btnMoveToDone);
            this.Controls.Add(this.btnMoveToInProcess);
            this.Controls.Add(this.lstTasksDone);
            this.Controls.Add(this.lstTasksInProcess);
            this.Controls.Add(this.lstNewTasks);
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
        private System.Windows.Forms.Button btnDeleteFromTasksDone;
        private System.Windows.Forms.Button btnDeleteFromInProcess;
        private System.Windows.Forms.Button btnDeleteFromNewTasks;
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTaskId;
    }
}

