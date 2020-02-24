using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProject.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int item_id { get; set; }
        [Required]
        [StringLength(20)]
        public string item_name { get; set; }
        public int? item_price { get; set; }
        public IEnumerable<Order> Orders { get; set; }

    }
}
