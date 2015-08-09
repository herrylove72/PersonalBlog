﻿using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Post:BaseEntity
    {
        public Post()
        {
            Tags=new List<Tag>();
        }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? Modified { get; set; }

        public Category Category { get; set; }
        public IList<Tag> Tags { get; set; }
        public User User { get; set; }
        
    }
}
