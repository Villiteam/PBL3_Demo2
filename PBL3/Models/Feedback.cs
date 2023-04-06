using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public double Ratting { get; set; }

    public string Comment { get; set; } = null!;

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
