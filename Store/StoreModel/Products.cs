namespace StoreModel;
public class Products
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    

    public override string ToString()
    {
        return $"Name: {Name}\nPrice: {Price}\nDescription: {Description}\nCategory: {Category}";
    }

}
