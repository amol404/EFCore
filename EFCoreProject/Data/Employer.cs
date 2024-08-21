namespace JobPortalApp.Data
{
    public class Employer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyContact { get; set; }
        public string CompanyWebsite { get; set; }
        public string Email { get; set; }

        //public ICollection<JobCategory> JobCategories { get; set; }
        //public ICollection<Message> Messages { get; set; }
    }
}
