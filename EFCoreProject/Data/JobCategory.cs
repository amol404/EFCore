using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalApp.Data
{
    public class JobCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int JobId { get; set; }

        //public Job Jobs { get; set; }
        //public ICollection<Job> Job { get; set; }
    }
}
