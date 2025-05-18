using System.ComponentModel;

namespace Clinictask.Models
{
    public class Healthcareolution:BaseModel
    {
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
     public int? ServiceId { get; set; }
        public Service? Service { get; set; }
    }
   
}
