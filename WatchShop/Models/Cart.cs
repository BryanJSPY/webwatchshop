using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchShop.Models
{
    public class Cart
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        [Key]
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemImage { get; set; }
        public long itemPrice { get; set; }
        public int itemQuatity { get; set; }
        public long total
        {
            get { return itemQuatity * itemPrice; }
        }
        public Cart(int id)
        {
            itemId = id;
            Item item = dbContext.Items.Single(n => n.ID == itemId);
            itemName = item.Name;
            itemImage = item.Image;
            itemPrice = long.Parse(item.Price.ToString());
            itemQuatity = 1;
        }
    }
}