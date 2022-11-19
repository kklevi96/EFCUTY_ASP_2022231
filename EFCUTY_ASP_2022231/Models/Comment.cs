using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCUTY_ASP_2022231.Models
{
    public class Comment
    {
        public Comment()
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
        public Post Post { get; set; }

        [ForeignKey(nameof(Post))]
        public string PostId { get; set; }

        [NotMapped]
        public SiteUser Author { get; set; }

        [ForeignKey(nameof(SiteUser))]
        public string SiteUserId { get; set; }
    }
}
