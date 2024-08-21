using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalApp.Data
{
    public class Job
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int JobCategoryId { get; set; }
        public int EmployerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public string Responsibilites { get; set; }
        public string City { get; set; }
        public int WorkingHours { get; set; }
        public int ExpectedSalary { get; set; }
        public int ExperienceRequired { get; set; }
        public string ExpectedEducation { get; set; }
        public bool HasBond { get; set; }
        public int NumberOfVacancy { get; set; }
        public string Jobtype {  get; set; }
        public int VoteUp { get; set; }
        public int VoteDown { get; set; }
        public bool IsActive {  get; set; }

        //public Employer Employer { get; set; }
        //public JobCategory JobCategory { get; set; }

        //public ICollection<JobCategory> JobCategories { get; set; }
        //public ICollection<JobApplication> JobApplications { get; set; }
        //public ICollection<Logs> Logs { get; set; }
        //public ICollection<Comments> Comments { get; set; }
        //public ICollection<WatchList> WatchLists { get; set; }

    }
}
