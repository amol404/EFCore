namespace JobPortalApp.Data
{
    public class Comments
    {
        public int Id { get; set; }
        public int Employee_Id { get; set; }
        public int JobId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        //public Employee Employees { get; set; }
        //public Job Jobs { get; set; }
    }
}
