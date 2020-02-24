using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFPractice.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? order_date { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? delivery_date { get; set; }
        [ForeignKey("item_id")]
        public Item Item { get; set; }

    }
}
