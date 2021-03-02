using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class CommentDetail
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public Guid OwnerId { get; set; }
    }
}
