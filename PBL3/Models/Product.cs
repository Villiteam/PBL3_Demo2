using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public double Price { get; set; }

    public double? PromotionPrice { get; set; }

    public string? ListImages { get; set; }

    public string? Video { get; set; }

    public int Quantity { get; set; }

    public string Description { get; set; } = null!;

    public bool IsSale { get; set; }

    public bool IsHot { get; set; }

    public bool? Status { get; set; }

    public int? ViewCount { get; set; }

    public int CatId { get; set; }

    public DateTime CreateDate { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public virtual Category Cat { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; } = new List<Comment>();

    public virtual ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual ICollection<ProductImage> ProductImages { get; } = new List<ProductImage>();

    public virtual ICollection<Warehouse> Warehouses { get; } = new List<Warehouse>();
}
