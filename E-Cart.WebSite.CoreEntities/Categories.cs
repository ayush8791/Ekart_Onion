using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Cart.WebSite.CoreEntities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
