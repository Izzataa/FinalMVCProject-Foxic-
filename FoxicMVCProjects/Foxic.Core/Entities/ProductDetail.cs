namespace Foxic.Core.Entities;

public class ProductDetail : BaseEntity
{
    public string ShortDesc { get; set; }
    public string LongDesc { get; set; }
    public Boolean Cotton { get; set; }
    public Boolean Polyester { get; set; }
    public Boolean Clean { get; set; }
    public Boolean Non_Chlorine {get; set;}
    public Boolean Tax { get; set; }

}
