﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _24HourChallenge.Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public virtual List<Reply> Replies { get; set; }
        [Required]
        [ForeignKey(nameof(Comment))]
        public int CommentId { get; set; }
    }
}