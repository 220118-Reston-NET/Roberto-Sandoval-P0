using StoreModel;

namespace StoreBL;

public interface IStoreFrontBL
{
    /// <summary>
    /// This function processes the request to see if a store exists in the database.
    /// If it does it returns the store's details
    /// </summary>
    /// <param name="p_storeNumber"></param>
    /// <returns></returns>
    (StoreFront, bool) findStore(StoreFront p_storeNumber);

    /// <summary>
    /// This function processes the request to find a product in the database
    /// </summary>
    /// <param name="p_product"></param>
    /// <returns></returns>
    (Products, bool) findProduct(Products p_product);

    /// <summary>
    /// This function processes the request to list all inventory for a certain store
    /// </summary>
    /// <param name="p_storeNumber"></param>
    /// <returns></returns>
    List<StoreInventory> listInventory(int p_storeNumber);

    /// <summary>
    /// This function processes the request to list all products in the database
    /// </summary>
    /// <returns></returns>
    List<Products> listOfProducts();

    /// <summary>
    /// This function processes the request to subtract inventory form the database for a certrain store
    /// </summary>
    /// <param name="p_stock"></param>
    void subtractInventory(List<StoreInventory> p_stock);

    /// <summary>
    /// This function processes the request to add inventory to the database for a certain store
    /// </summary>
    /// <param name="p_stock"></param>
    void addInventory(List<StoreInventory> p_stock);
    

}