using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class PostDetail
    {
        public int PostId { get; set; }
        [MaxLength(100, ErrorMessage = "You have reached the character limit")]
        public string Title { get; set; }
        [MaxLength(4000, ErrorMessage = "You have reached the character limit")]
        public string Content { get; set; }

    }
}
