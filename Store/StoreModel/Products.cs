namespace StoreModel;
public class Products
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    public int ProductQuantity { get; set; }
    public string ProductDescription { get; set; }
    public string ProductCategory { get; set; }
    

    public override string ToString()
    {
        return $"Name: {ProductName}\nPrice: {ProductPrice}\nDescription: {ProductDescription}\nCategory: {ProductCategory}\nQuantity Available: {ProductQuantity}";
    }

}
