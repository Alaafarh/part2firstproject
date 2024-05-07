using System;
using System.Collections.Generic;

namespace FirstPro.Models;

public partial class Orderrecipe
{
    public decimal Orderrecipe1 { get; set; }

    public decimal? Userid { get; set; }

    public decimal? Recipeid { get; set; }

    public DateTime? Shopdate { get; set; }

    public decimal? Totalprice { get; set; }

    public virtual Recipe? Recipe { get; set; }

    public virtual User? User { get; set; }
}
