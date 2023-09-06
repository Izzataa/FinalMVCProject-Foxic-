namespace Foxic.Core.Entities;

public class Image:BaseEntity
{
    public int ProductId { get; set; }
    public Product Product { get; set; }

}
