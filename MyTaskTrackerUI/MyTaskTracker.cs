using System.Windows.Forms;
using MyTaskTrackerLibrary;

namespace MyTaskTrackerUI
{
    public partial class MyTaskTracker : Form
    {
        private User user = new User();
        BindingSource taskBinding = new BindingSource();
        public MyTaskTracker()
        {
            InitializeComponent();
            SetUpData();

            taskBinding.DataSource = user.Tasks;
            lstNewTasks.DataSource = taskBinding;

            lstNewTasks.DisplayMember = "Title";
            lstNewTasks.ValueMember = "Title";
        }

        private void SetUpData()
        {
            Task t1 = new Task();
            Task t2 = new Task();
            Task t3 = new Task();

            t1.Title = "Task 1";
            t2.Title = "Task 2";
            t3.Title = "Task 3";

            user.Tasks.Add(t1);
            user.Tasks.Add(t2);
            user.Tasks.Add(t3);
        }
    }
}
