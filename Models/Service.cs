using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinictask.Models
{
    public class Service:BaseModel
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile ImageUpload { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Healthcareolution> Healthcareolutions       {get; set; }
    }
}
