﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class ReplyDetail
    {
        public int ReplyId { get; set; }
        public string Content { get; set; }
        public Guid OwnerId { get; set; }
    }
}
