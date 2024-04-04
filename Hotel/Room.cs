using System;
using System.Collections.Generic;

namespace Hotel;

public partial class Room
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Statuc { get; set; }

    public int? Room1 { get; set; }

    public DateOnly? AarrivalDate { get; set; }

    public DateOnly? DaateOfdeparture { get; set; }

    public int? Days { get; set; }

    public int? Defrayment { get; set; }

    public DateOnly? Birthday { get; set; }

    public int? Animal { get; set; }

    public byte[]? Picture { get; set; }
}
