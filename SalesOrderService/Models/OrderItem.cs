using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SalesOrderService.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        [Required]
        public int OrderId { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }

        [Required]
        public int ItemId { get; set; }
        
        public virtual Item Item { get; set; }





        public OrderItem()
        {

        }
    }
}
