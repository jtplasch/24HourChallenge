using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "You have reached the character limit")]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
       
        public Guid UserId { get; set; }

    }
}
