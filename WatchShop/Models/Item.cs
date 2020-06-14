using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchShop.Models
{
    public class Item
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public long Price { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }     
        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Image { get; set; }
    }
}