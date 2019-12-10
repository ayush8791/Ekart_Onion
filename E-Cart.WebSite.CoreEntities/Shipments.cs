using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace E_Cart.WebSite.CoreEntities
{
    public class Shipments
    {
        [Key]
        public int ShipmentId { get; set; }
        public DateTime DateStamp { get; set; }

        
    }
}
