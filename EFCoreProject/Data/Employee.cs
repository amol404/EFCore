namespace JobPortalApp.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Experience { get; set; }
        public string Education {  get; set; }
        public string PastWork { get; set; }
        //public BinaryData Image { get; set; }
        //public BinaryData Resume { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        //public ICollection<JobApplication> JobApplications { get; set; }
        //public ICollection<Logs> Logs { get; set; }
        //public ICollection<Comments> Comments { get; set; }
        //public ICollection<WatchList> WatchLists { get; set; }
        //public ICollection<Message> Messages { get; set; }
    }
}
