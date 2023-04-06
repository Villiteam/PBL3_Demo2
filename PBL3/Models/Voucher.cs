using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Voucher
{
    public int VoucherId { get; set; }

    public string VoucherName { get; set; } = null!;

    public bool? Status { get; set; }

    public double Disscount { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
