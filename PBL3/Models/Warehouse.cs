using System;
using System.Collections.Generic;

namespace PBL3.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual Product Product { get; set; } = null!;
}
