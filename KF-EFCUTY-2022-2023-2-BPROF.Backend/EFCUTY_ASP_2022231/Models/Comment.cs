﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        public DateTime Timestamp { get; set; }

        public DateTime? LastEdited { get; set; }

        public int EditCount { get; set; }

        [NotMapped]
        public virtual Post Post { get; set; }

        [ForeignKey(nameof(Post))]
        public string PostId { get; set; }

        [NotMapped]
        public virtual SiteUser Author { get; set; }

        [ForeignKey(nameof(SiteUser))]
        public string SiteUserId { get; set; }
    }
}
