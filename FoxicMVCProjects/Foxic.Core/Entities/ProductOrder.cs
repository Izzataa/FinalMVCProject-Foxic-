namespace Foxic.Core.Entities;

public class ProductOrder:BaseEntity
{
   public int Count { get; set; }
    public int Price { get; set; }  
    public string Size { get; set; }
    public string Color { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
