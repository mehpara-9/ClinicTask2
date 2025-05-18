using System.ComponentModel.DataAnnotations;

namespace Clinictask.Models
{
    public class Category:BaseModel
    {
        [Required,MinLength(4),MaxLength(26)]
        
        public string Title { get; set; }
        public ICollection<Healthcareolution> Healthcareolutions { get; set; }
        public ICollection<Service> Services { get; set; }

    }
}
