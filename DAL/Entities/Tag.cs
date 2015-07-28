﻿using System.Collections.Generic;

namespace DAL.Entities
{
    public class Tag:BaseEntity<int>
    {
        public Tag()
        {
            Posts=new List<Post>();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
