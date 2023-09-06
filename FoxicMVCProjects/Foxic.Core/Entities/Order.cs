namespace Foxic.Core.Entities;

public class Order:BaseEntity
{
    public int TotalPrice { get; set; }
    public DateTime CreatedTime { get; set; }
    public string Description { get; set; }
    public  ICollection<ProductOrder>Products { get; set; }    
    
}
