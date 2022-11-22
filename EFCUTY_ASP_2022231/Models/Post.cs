using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCUTY_ASP_2022231.Models
{
    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Timestamp = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? LastEdited { get; set; }

        public int EditCount { get; set; }

        [NotMapped]
        public virtual SiteUser Author { get; set; }

        [ForeignKey(nameof(SiteUser))]
        public string SiteUserId { get; set; }

        [NotMapped]
        public virtual Subject Subject { get; set; }

        [ForeignKey(nameof(Subject))]
        public string SubjectCode { get; set; }

        [NotMapped]
        public virtual List<Comment> Comments { get; set; }
    }
}
