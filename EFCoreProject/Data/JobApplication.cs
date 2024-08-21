namespace JobPortalApp.Data
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int JobId { get; set; }
        public int JobStatus { get; set; }

        //public Employee Employees { get; set; }
        //public Job Jobs { get; set; }
    }
}
