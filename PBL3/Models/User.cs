using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool? Status { get; set; }

    public int Role { get; set; }

    public string? CreditCard { get; set; }

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Role RoleNavigation { get; set; } = null!;
}
