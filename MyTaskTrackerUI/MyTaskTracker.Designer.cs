﻿namespace MyTaskTrackerUI
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
            this.lstNewTasks.Location = new System.Drawing.Point(12, 55);
            this.lstNewTasks.Name = "lstNewTasks";
            this.lstNewTasks.Size = new System.Drawing.Size(210, 212);
            this.lstNewTasks.TabIndex = 0;
            // 
            // lstTasksInProcess
            // 
            this.lstTasksInProcess.FormattingEnabled = true;
            this.lstTasksInProcess.Location = new System.Drawing.Point(300, 55);
            this.lstTasksInProcess.Name = "lstTasksInProcess";
            this.lstTasksInProcess.Size = new System.Drawing.Size(210, 212);
            this.lstTasksInProcess.TabIndex = 1;
            // 
            // lstTasksDone
            // 
            this.lstTasksDone.FormattingEnabled = true;
            this.lstTasksDone.Location = new System.Drawing.Point(591, 55);
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
            // 
            // btnMoveToDone
            // 
            this.btnMoveToDone.Location = new System.Drawing.Point(519, 143);
            this.btnMoveToDone.Name = "btnMoveToDone";
            this.btnMoveToDone.Size = new System.Drawing.Size(66, 23);
            this.btnMoveToDone.TabIndex = 4;
            this.btnMoveToDone.Text = ">>";
            this.btnMoveToDone.UseVisualStyleBackColor = true;
            // 
            // btnReturnToTasksInProcess
            // 
            this.btnReturnToTasksInProcess.Location = new System.Drawing.Point(519, 172);
            this.btnReturnToTasksInProcess.Name = "btnReturnToTasksInProcess";
            this.btnReturnToTasksInProcess.Size = new System.Drawing.Size(66, 23);
            this.btnReturnToTasksInProcess.TabIndex = 5;
            this.btnReturnToTasksInProcess.Text = "<<";
            this.btnReturnToTasksInProcess.UseVisualStyleBackColor = true;
            // 
            // btnReturnToNewTasks
            // 
            this.btnReturnToNewTasks.Location = new System.Drawing.Point(228, 172);
            this.btnReturnToNewTasks.Name = "btnReturnToNewTasks";
            this.btnReturnToNewTasks.Size = new System.Drawing.Size(66, 23);
            this.btnReturnToNewTasks.TabIndex = 6;
            this.btnReturnToNewTasks.Text = "<<";
            this.btnReturnToNewTasks.UseVisualStyleBackColor = true;
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Location = new System.Drawing.Point(12, 273);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(66, 23);
            this.btnAddNewTask.TabIndex = 7;
            this.btnAddNewTask.Text = "Add";
            this.btnAddNewTask.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFromNewTasks
            // 
            this.btnDeleteFromNewTasks.Location = new System.Drawing.Point(156, 273);
            this.btnDeleteFromNewTasks.Name = "btnDeleteFromNewTasks";
            this.btnDeleteFromNewTasks.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteFromNewTasks.TabIndex = 8;
            this.btnDeleteFromNewTasks.Text = "Delete";
            this.btnDeleteFromNewTasks.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFromInProcess
            // 
            this.btnDeleteFromInProcess.Location = new System.Drawing.Point(444, 273);
            this.btnDeleteFromInProcess.Name = "btnDeleteFromInProcess";
            this.btnDeleteFromInProcess.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteFromInProcess.TabIndex = 9;
            this.btnDeleteFromInProcess.Text = "Delete";
            this.btnDeleteFromInProcess.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFromTasksDone
            // 
            this.btnDeleteFromTasksDone.Location = new System.Drawing.Point(735, 273);
            this.btnDeleteFromTasksDone.Name = "btnDeleteFromTasksDone";
            this.btnDeleteFromTasksDone.Size = new System.Drawing.Size(66, 23);
            this.btnDeleteFromTasksDone.TabIndex = 10;
            this.btnDeleteFromTasksDone.Text = "Delete";
            this.btnDeleteFromTasksDone.UseVisualStyleBackColor = true;
            // 
            // lblNewTask
            // 
            this.lblNewTask.AutoSize = true;
            this.lblNewTask.Location = new System.Drawing.Point(9, 39);
            this.lblNewTask.Name = "lblNewTask";
            this.lblNewTask.Size = new System.Drawing.Size(56, 13);
            this.lblNewTask.TabIndex = 11;
            this.lblNewTask.Text = "New Task";
            // 
            // lblTaskInProcess
            // 
            this.lblTaskInProcess.AutoSize = true;
            this.lblTaskInProcess.Location = new System.Drawing.Point(297, 39);
            this.lblTaskInProcess.Name = "lblTaskInProcess";
            this.lblTaskInProcess.Size = new System.Drawing.Size(57, 13);
            this.lblTaskInProcess.TabIndex = 12;
            this.lblTaskInProcess.Text = "In Process";
            // 
            // lblTaskDone
            // 
            this.lblTaskDone.AutoSize = true;
            this.lblTaskDone.Location = new System.Drawing.Point(588, 39);
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
            this.btnCloseForm.Text = "button9";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            // 
            // MyTaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 365);
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
    }
}

