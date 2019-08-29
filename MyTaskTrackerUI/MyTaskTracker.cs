using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using MyTaskTrackerLibrary;
using DAL.Operators;

namespace MyTaskTrackerUI
{
    public partial class MyTaskTracker : Form
    {
        private User user = new User();
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
            user.Tasks = OpTask.SelectAll();
            user.Id = 1;
        }

        private void btnMoveToInProcess_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstNewTasks.SelectedItem;

            if (selectedTask != null)
            {
                foreach (Task t in user.Tasks)
                {
                    if (t.Id == selectedTask.Id)
                    {
                        t.Status = 2;
                    }
                } 
            }

            RefreshLstNewTasks();
            RefreshLstTasksInProcess();
        }


        private void btnReturnToNewTasks_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstTasksInProcess.SelectedItem;

            if (selectedTask != null)
            {
                foreach (Task t in user.Tasks)
                {
                    if (t.Id == selectedTask.Id)
                    {
                        t.Status = 1;
                    }
                }
            }

            RefreshLstNewTasks();
            RefreshLstTasksInProcess();
        }

        private void btnMoveToDone_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstTasksInProcess.SelectedItem;

            if (selectedTask != null)
            {
                foreach (Task t in user.Tasks)
                {
                    if (t.Id == selectedTask.Id)
                    {
                        t.Status = 3;
                    }
                }
            }

            RefreshLstTasksInProcess();
            RefreshLstTasksDone();
        }

        private void btnReturnToTasksInProcess_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstTasksDone.SelectedItem;

            if (selectedTask != null)
            {
                foreach (Task t in user.Tasks)
                {
                    if (t.Id == selectedTask.Id)
                    {
                        t.Status = 2;
                    }
                }
            }

            RefreshLstTasksInProcess();
            RefreshLstTasksDone();
        }

        private void btnDeleteFromNewTasks_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstNewTasks.SelectedItem;

            if (selectedTask != null)
            {
                if (DeleteMessageBox())
                {
                    foreach (Task t in user.Tasks)
                    {
                        if (t.Id == selectedTask.Id)
                        {
                            t.Deleted = 0;
                        }
                    }
                    RefreshLstNewTasks();
                }
            }
        }

        private void btnDeleteFromInProcess_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstTasksInProcess.SelectedItem;

            if (selectedTask != null)
            {
                if (DeleteMessageBox())
                {
                    foreach (Task t in user.Tasks)
                    {
                        if (t.Id == selectedTask.Id)
                        {
                            t.Deleted = 0;
                        }
                    }
                    RefreshLstTasksInProcess();
                }
            }
        }

        private void BtnDeleteFromTasksDone_Click(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)lstTasksDone.SelectedItem;

            if (selectedTask != null)
            {
                if (DeleteMessageBox())
                {
                    foreach (Task t in user.Tasks)
                    {
                        if (t.Id == selectedTask.Id)
                        {
                            t.Deleted = 0;
                        }
                    }
                    RefreshLstTasksDone();
                }
            }
        }

        private void BtnAddNewTask_Click(object sender, System.EventArgs e)
        {
            //ToDo: Add new form for adding tasks
        }

        private void BtnCloseForm_Click(object sender, System.EventArgs e)
        {
            this.Close(); 
        }

        private void RefreshLstNewTasks()
        {
            newTasksList = user.Tasks.Where(x => x.Status == 1 && x.Deleted == 0).ToList();

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

            tasksInProcessList = user.Tasks.Where(x => x.Status == 2 && x.Deleted == 0).ToList();

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

            tasksDoneList = user.Tasks.Where(x => x.Status == 3 && x.Deleted == 0).ToList();

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
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
