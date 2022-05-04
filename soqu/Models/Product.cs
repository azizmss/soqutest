using System;
using System.Collections.Generic;

namespace soqu.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? CatId { get; set; }
        public string? Photo { get; set; }

        public virtual Catagory? Cat { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
