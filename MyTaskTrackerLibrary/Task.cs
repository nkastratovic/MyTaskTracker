namespace MyTaskTrackerLibrary
{
    public class Task
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public int Deleted { get; set; }
        public int UserId { get; set; }
        #endregion
    }
}