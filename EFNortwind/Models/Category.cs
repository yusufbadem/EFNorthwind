﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwind.Models;
public class Category
{
    public int CategoryId { get; set; }
    public string  CategoryName { get; set; }
    public string? Description { get; set; }
    public byte? Picture { get; set; }
}
