﻿namespace Foxic.Core.Entities;

public class Brand:BaseEntity
{
    public string Name { get; set; }
    public string Image { get; set; }
    public ICollection<Product> Products { get; set; }

}
