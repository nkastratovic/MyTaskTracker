using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using MyTaskTrackerLibrary;
using DAL.Operators;
using System;

namespace MyTaskTrackerUI
{
    public partial class MyTaskTracker : Form
    {
        private List<Task> tasks = new List<Task>();
        private List<Task> newTasksList = new List<Task>();
        private List<Task> tasksInProcessList = new List<Task>();
        private List<Task> tasksDoneList = new List<Task>();

        private BindingSource newTaskBinding = new BindingSource();
        private BindingSource tasksInProcessBinding = new BindingSource();
        private BindingSource tasksDoneBinding = new BindingSource(); 

        public MyTaskTracker()
        {
            InitializeComponent();
            SetUpData();
            RefreshLstNewTasks();
            RefreshLstTasksInProcess();
            RefreshLstTasksDone();
        }

        private void SetUpData()
        {
            tasks = OpTask.Select();
        }

        private void btnMoveToInProcess_Click(object sender, System.EventArgs e)
        {
            if(txtTaskStatus.Text=="1")
            {
                txtTaskStatus.Text = "2";
                btnTaskUpdate.PerformClick();
                SetUpData();
                RefreshLstNewTasks();
                RefreshLstTasksInProcess();
            }
        }

        private void btnReturnToNewTasks_Click(object sender, System.EventArgs e)
        {
            if (txtTaskStatus.Text == "2")
            {
                txtTaskStatus.Text = "1";
                btnTaskUpdate.PerformClick();
                SetUpData();
                RefreshLstNewTasks();
                RefreshLstTasksInProcess();
            }
        }

        private void btnMoveToDone_Click(object sender, System.EventArgs e)
        {
            if (txtTaskStatus.Text == "2")
            {
                txtTaskStatus.Text = "3";
                btnTaskUpdate.PerformClick();
                SetUpData();
                RefreshLstTasksInProcess();
                RefreshLstTasksDone();
            }
        }

        private void btnReturnToTasksInProcess_Click(object sender, System.EventArgs e)
        {
            if (txtTaskStatus.Text == "3")
            {
                txtTaskStatus.Text = "2";
                btnTaskUpdate.PerformClick();
                SetUpData();
                RefreshLstTasksInProcess();
                RefreshLstTasksDone();
            }
        }

        private void BtnAddNewTask_Click(object sender, System.EventArgs e)
        {
            if (txtTaskTitle.Text == String.Empty)
            {
                lblTaskMastHaveName.Visible = true;
            }
            else
            {
                OpTask.Insert(txtTaskTitle.Text, txtTaskDescription.Text, 1);
                txtTaskTitle.Text = string.Empty;
                txtTaskDescription.Text = string.Empty;

                SetUpData();
                RefreshLstNewTasks();
                RefreshLstTasksInProcess();
                RefreshLstTasksDone();
            }
        }

        private void BtnCloseForm_Click(object sender, System.EventArgs e)
        {
            this.Close(); 
        }

        private void RefreshLstNewTasks()
        {
            newTasksList = tasks.Where(x => x.StatusId == 1).ToList();

            if (newTasksList.Any())
            {
                newTaskBinding.DataSource = newTasksList;
                lstNewTasks.DataSource = newTaskBinding;

                lstNewTasks.DisplayMember = "Title";
                lstNewTasks.ValueMember = "Title";
            }
            else
            {
                lstNewTasks.DataSource = null;
            }
        }

        private void RefreshLstTasksInProcess()
        {

            tasksInProcessList = tasks.Where(x => x.StatusId == 2).ToList();

            if (tasksInProcessList.Any())
            {
                tasksInProcessBinding.DataSource = tasksInProcessList;
                lstTasksInProcess.DataSource = tasksInProcessBinding;

                lstTasksInProcess.DisplayMember = "Title";
                lstTasksInProcess.ValueMember = "Title";
            }
            else
            {
                lstTasksInProcess.DataSource = null;
            }
        }

        private void RefreshLstTasksDone()
        {

            tasksDoneList = tasks.Where(x => x.StatusId == 3).ToList();

            if (tasksDoneList.Any())
            {
                tasksDoneBinding.DataSource = tasksDoneList;
                lstTasksDone.DataSource = tasksDoneBinding;

                lstTasksDone.DisplayMember = "Title";
                lstTasksDone.ValueMember = "Title";
            }
            else
            {
                lstTasksDone.DataSource = null;
            }
        }

        private bool DeleteMessageBox()
        {
            DialogResult myResult;

            myResult = MessageBox.Show("Are you really delete the item?", "Delete comfirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Label1_Click(object sender, System.EventArgs e)
        {

        }

        private void LblNewTask_Click(object sender, System.EventArgs e)
        {

        }

        private void LstNewTasks_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstNewTasks.SelectedItem;
            selectedTask = OpTask.Select((int)selectedTask.Id);
            txtTaskId.Text = selectedTask.Id.ToString();
            txtTaskStatus.Text = selectedTask.StatusId.ToString();
            txtTaskTitle.Text = selectedTask.Title.ToString();
            txtTaskDescription.Text = selectedTask.Description.ToString();
        }

        private void LstTasksInProcess_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void LstTasksDone_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void BtnTaskUpdate_Click(object sender, System.EventArgs e)
        {
            if (txtTaskId.Text != String.Empty)
            {
                OpTask.Update(Convert.ToInt32(txtTaskId.Text), txtTaskTitle.Text, txtTaskDescription.Text, Convert.ToInt32(txtTaskStatus.Text));

                SetUpData();
                RefreshLstNewTasks();
                RefreshLstTasksInProcess();
                RefreshLstTasksDone();
            }
        }

        private void TxtTaskDelete_Click(object sender, EventArgs e)
        {
            if (DeleteMessageBox())
            {
                OpTask.Delete(Convert.ToInt32(txtTaskId.Text));
                SetUpData();
                RefreshLstNewTasks();
                RefreshLstTasksInProcess();
                RefreshLstTasksDone();
            }
        }

        private void LstTasksInProcess_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)lstTasksInProcess.SelectedItem;
            selectedTask = OpTask.Select((int)selectedTask.Id);
            txtTaskId.Text = selectedTask.Id.ToString();
            txtTaskStatus.Text = selectedTask.StatusId.ToString();
            txtTaskTitle.Text = selectedTask.Title.ToString();
            txtTaskDescription.Text = selectedTask.Description.ToString();
        }

        private void LstTasksDone_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)lstTasksDone.SelectedItem;
            selectedTask = OpTask.Select((int)selectedTask.Id);
            txtTaskId.Text = selectedTask.Id.ToString();
            txtTaskStatus.Text = selectedTask.StatusId.ToString();
            txtTaskTitle.Text = selectedTask.Title.ToString();
            txtTaskDescription.Text = selectedTask.Description.ToString();
        }
    }
}
