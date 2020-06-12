using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }

        //public virtual int CategoryId { get; set; }
        //public virtual Category Categories { get; set; }

    }
}
