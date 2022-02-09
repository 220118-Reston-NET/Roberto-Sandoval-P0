using StoreBL;
using StoreModel;

namespace StoreUI;

class ViewOrderHistoryMenu : IMenu
{
    private List<Products> _productsForOrder = new List<Products>();
    private static Costumer _newCostumer = new Costumer();

    private ICostumerBL _costumerBL;
    public ViewOrderHistoryMenu(ICostumerBL p_costumerBL)
    {
        _costumerBL = p_costumerBL;
    }
    public void ShowMenu()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("           Store Management System 2.0  ");
        Console.WriteLine("==================================================");
        Console.WriteLine();
        Console.WriteLine("         Please Select Order Type to Search\n");
        Console.WriteLine($"             <3> Name: {_newCostumer.Name}");
        Console.WriteLine($"             <2> Phone: {_newCostumer.Phone}");
        Console.WriteLine("             <1> View Order History");
        Console.WriteLine("             <0> Main Menu\n\n");
        Console.Write(" Choice: ");
    }

    public string UserPick()
    {
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "0":
                return "MainMenu";
            case "1":
                processInput();
                return "MainMenu";
            case "2":
                Console.WriteLine("Please Enter Costumer Phone Number");
                _newCostumer.Phone = Console.ReadLine();
                return "OrderHistory";
            case "3":
                Console.WriteLine("Please Enter Costumer Name:");
                _newCostumer.Name = Console.ReadLine();
                return "OrderHistory";
            default:
                Console.WriteLine("You Have Entered An Invalid Choice");
                Console.WriteLine("Press ENTER to try again");
                Console.ReadLine();
                return "OrderHistory";
        }
        
    }

    public void processInput()
    {
        List<Orders> orderList = _costumerBL.orderHistory(_newCostumer.CostumerId);

        foreach (var item in orderList)
        {
            Console.WriteLine(item.ToString);
        }
    }
}