using System;
using System.Collections.Generic;

namespace MyCards.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();

    public virtual User User { get; set; } = null!;
}
