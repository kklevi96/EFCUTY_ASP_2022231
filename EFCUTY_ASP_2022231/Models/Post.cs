using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCUTY_ASP_2022231.Models
{
    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }

        public byte[]? Data { get; set; } // attached picture(s), optional

        public DateTime Timestamp { get; set; }

        [NotMapped]
        public SiteUser Author { get; set; }

        [ForeignKey(nameof(SiteUser))]
        public string SiteUserId { get; set; }

        [NotMapped]
        public Subject Subject { get; set; }

        [ForeignKey(nameof(Subject))]
        public string SubjectCode { get; set; }
    }
}
