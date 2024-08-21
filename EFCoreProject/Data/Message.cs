namespace JobPortalApp.Data
{
    public class Message
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        //public Employee Employees { get; set; }
        //public Employer Employers { get; set; }
    }
}
