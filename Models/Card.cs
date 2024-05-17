using System;
using System.Collections.Generic;

namespace MyCards.Models;

public partial class Card
{
    public int Id { get; set; }

    public string Front { get; set; } = null!;

    public string Back { get; set; } = null!;

    public string? FrontNotice { get; set; }

    public string? BackNotice { get; set; }

    public int CategoryId { get; set; }

    public int Color { get; set; }

    public string? Completed { get; set; }

    public virtual Category Category { get; set; } = null!;
}
