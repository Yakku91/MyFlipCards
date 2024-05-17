using System;
using System.Collections.Generic;

namespace MyCards.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
