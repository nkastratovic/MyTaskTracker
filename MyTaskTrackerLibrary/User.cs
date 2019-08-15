using System.Collections.Generic;

namespace MyTaskTrackerLibrary
{
    public class User
    {
        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Task> Tasks { get; set; }
        #endregion

        #region Constructor
        public User()
        {
            Tasks = new List<Task>();
        }
        #endregion
    }
}
