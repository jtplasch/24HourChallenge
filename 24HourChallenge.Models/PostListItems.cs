﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HourChallenge.Models
{
    public class PostListItems
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }    
    }
}
