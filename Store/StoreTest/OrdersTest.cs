using System.Collections.Generic;
using Moq;
using StoreBL;
using StoreDL;
using StoreModel;
using Xunit;

namespace StoreTest;

public class OrderTest
{
    [Fact]
    public void TestDataInt()
    {
        //Arrange
        Orders newOrder = new Orders();
        int orderNumber = 300010;
        int costumerId = 1010;
        int storeNumber = 135;

        //Act
        newOrder.OrderNumber = orderNumber;
        newOrder.CostumerId = costumerId;
        newOrder.StoreNumber = storeNumber;

        //Assert
        Assert.NotNull(newOrder.OrderNumber);
        Assert.Equal(orderNumber, newOrder.OrderNumber);

        Assert.NotNull(newOrder.CostumerId);
        Assert.Equal(costumerId, newOrder.CostumerId);

        Assert.NotNull(newOrder.StoreNumber);
        Assert.Equal(storeNumber, newOrder.StoreNumber);
    }

    [Fact]
    public void TestDataDouble()
    {
        //Arrange
        Orders newOrder = new Orders();
        double orderTotal = 5.99;

        //Act
        newOrder.OrderTotal = orderTotal;

        //Assert
        Assert.NotNull(newOrder.OrderTotal);
        Assert.Equal(orderTotal, newOrder.OrderTotal);
    }

    [Fact]
    public void OrderList()
    {
        //Arrange
        int orderNumber = 300010;
        int costumerId = 1010;
        int storeNumber = 135;
        double orderTotal = 5.99;

        Orders newOrder = new Orders()
        {
            OrderNumber = orderNumber,
            CostumerId = costumerId,
            StoreNumber = storeNumber,
            OrderTotal = orderTotal,


        };

        List<Orders> expectedList = new List<Orders>();
        expectedList.Add(newOrder);

        Mock<IRepository> mockRepo = new Mock<IRepository>();

        mockRepo.Setup(repo => repo.ListOfOrders(1010)).Returns(expectedList);

        ICostumerBL costumerBL = new CostumerBL(mockRepo.Object);

        //Act
        List<Orders> actualList = costumerBL.orderHistory(1010);

        //Assert
        Assert.Equal(expectedList, actualList);
    }
}