﻿using System;
using System.Collections.Generic;
using TicketingApp.Models.Dto;

namespace TicketingApp.Models;

public partial class TicketCategory
{
    public int TicketCategoryId { get; set; }

    public int? EventId { get; set; }

    public string? Description { get; set; }

    public double Price { get; set; }

    public virtual Event? Event { get; set; }

    //public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
