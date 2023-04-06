using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public bool? Status { get; set; }

    public bool? Delivered { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int UserId { get; set; }

    public bool IsPay { get; set; }

    public string PayType { get; set; } = null!;

    public int? VoucherId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual User User { get; set; } = null!;

    public virtual Voucher? Voucher { get; set; }
}
