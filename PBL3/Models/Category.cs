using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Category
{
    public int CatId { get; set; }

    public string CatName { get; set; } = null!;

    public bool? Status { get; set; }

    public int? ParentId { get; set; }

    public virtual ICollection<Category> InverseParent { get; } = new List<Category>();

    public virtual Category? Parent { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
