using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PurchaseLemonade()
        {
            Random random = new Random();
            Weather weather = new Weather(random);
            Store store = new Store();
            Recipe recipe = new Recipe();
            Inventory items = new Inventory(recipe);
            Player player = new Player(store);
            Wallet wallet = new Wallet();
            Day day = new Day(weather, player, random);
            Customer customer = new Customer(weather, recipe, random);
            //Arrange
            
            player.recipe.cupPrice = 1;
            day.customerCount = 0;
            player.items.pitcherCups = 4;
 
            //Act
            day.PurchaseLemonade(customer);           
            //Assert
            Assert.IsTrue(day.dailyTotal > 0 && player.wallet.startingCash > 10 && day.customerCount == 1 && player.items.pitcherCups == 3);
        }




        public void TestPreferSugar()
        {
            //Arrange
            Recipe recipe = new Recipe();
            Random random = new Random();
            Weather weather = new Weather(random);
            Customer customer = new Customer(weather, recipe, random);
            //Act
            customer.PreferSugar();
            //Assert
            Assert.IsTrue(customer.preferSugar >= 0 && customer.preferSugar < 6);
        }
        [TestMethod]

        public void TestCreateRandomNumber()
        {
            //Arrange
            Store store = new Store();
            Player player = new Player(store);
            Random random = new Random();
            Weather weather = new Weather(random);           
            Day day = new Day(weather , player, random);
            //Act
            day.CreateRandomNumber();
            //Assert
            Assert.IsTrue(day.purchaseComparer >= 0 && day.purchaseComparer < 100);
        }
        [TestMethod]

        public void TestBalanceCheckPass()
        {
            Wallet wallet = new Wallet();
            //arrange
            double cost= 10;
            
            bool result = wallet.CheckBalance(cost);
            //assert
            Assert.IsTrue(true == result);
        }
        [TestMethod]
        public void TestBalanceCheckFail()
        {
            Wallet wallet = new Wallet();

            //arange
            double cost = 11;
            //act
            bool result = wallet.CheckBalance(cost);
            //assert
            Assert.IsTrue(false == result);
        }

    }
}
