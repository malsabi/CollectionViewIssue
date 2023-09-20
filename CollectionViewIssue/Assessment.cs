namespace CollectionViewIssue
{
    public enum AssessmentStatus : int
    {
        Pending = 0,
        Grading = 1,
        Completed = 2,
    }

    public class Assessment
    {
        public string Title { get; set; }
        public string Program { get; set; }
        public string Course { get; set; }
        public string EndDate { get; set; }
        public double CurrentProgress { get; set; }
        public double TotalProgress { get; set; }
        public AssessmentStatus Status { get; set; }
    }
}