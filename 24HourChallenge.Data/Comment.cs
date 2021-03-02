using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _24HourChallenge.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}