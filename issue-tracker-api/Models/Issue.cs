namespace issue_tracker_api.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public enum Priority
    {

    }
}
