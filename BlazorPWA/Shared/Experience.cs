namespace BlazorPWA.Shared
{
    public class Experience
    {
        public string Position { get; set; }
        public string Company { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public List<string> Projects { get; set; }
        public List<string> LanguagesTools { get; set; }
    }
}