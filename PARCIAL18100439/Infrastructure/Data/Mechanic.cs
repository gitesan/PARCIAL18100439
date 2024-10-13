using System;
using System.Collections.Generic;

namespace PARCIAL18100439.Infrastructure.Data;

public partial class Mechanic
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public int? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public int? HireDate { get; set; }
}
