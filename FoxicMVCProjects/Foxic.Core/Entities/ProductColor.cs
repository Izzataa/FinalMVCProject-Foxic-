namespace Foxic.Core.Entities;

public class ProductColor:BaseEntity
{
    public int ColorId { get; set; }
    public Color Colors { get; set; }
    public int ProductId { get; set; }
    public Product Products { get; set; }
}
