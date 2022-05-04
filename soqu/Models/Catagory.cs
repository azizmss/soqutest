using System;
using System.Collections.Generic;

namespace soqu.Models
{
    public partial class Catagory
    {
        public Catagory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Photo { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
