namespace DbFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]


        public int oID { get; set; }
        public int? cID { get; set; }
        public int? pID { get; set; }

        [DisplayName("Order Date")]
        public DateTime? orderDate { get; set; }

        [DisplayName("Payment Status")]

        [UIHint("PaymentStatusBool")]
        public bool? paymentStatus { get; set; }
        [DisplayName("Quantity")]
        public int? quantity { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
