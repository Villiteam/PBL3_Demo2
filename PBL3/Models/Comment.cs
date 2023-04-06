using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int ProductId { get; set; }

    public DateTime CreateDate { get; set; }

    public int UserId { get; set; }

    public string Comment1 { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
