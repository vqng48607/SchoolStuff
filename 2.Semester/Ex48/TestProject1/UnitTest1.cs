using BonusApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Order order;

        [TestInitialize]
        public void InitializeTest()
        {
            order = new Order();
            order.AddProduct(new Product
            {
                Name = "Mælk",
                Value = 10.0
            });
            order.AddProduct(new Product
            {
                Name = "Smør",
                Value = 15.0
            });
            order.AddProduct(new Product
            {
                Name = "Pålæg",
                Value = 20.0
            });
        }

        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(4.5, Bonuses.TenPercent(45.0));
            Assert.AreEqual(40.0, Bonuses.TenPercent(400.0));
        }

        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, Bonuses.FlatTwoIfAmountMoreThanFive(10.0));
            Assert.AreEqual(0.0, Bonuses.FlatTwoIfAmountMoreThanFive(4.0));
        }

        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(45.0, order.GetValueOfProducts());
        }

        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(40.5, order.GetTotalPrice());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(43.0, order.GetTotalPrice());
        }

        [TestMethod]
        public void GetBonusAnonymous_Test()
        {
            order.Bonus = delegate(double amount) { return amount * 0.1; }; // <- Change to anonymous method
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = delegate(double amount) 
            {
                if (amount > 5)
                {
                    amount = 2.0;
                }
                else amount = 0.0;
                return amount; 
            }; // <- Change to anonymous method

            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetBonusLambda_Test()
        {
            order.Bonus = (x) => x * 0.1; // <- Change to lambda expression
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = (x) =>
            {
                if (x > 5)
                    x = 2.0;
                else x = 0.0;

                return x;
            }; // <- Change to lambda expression

            Assert.AreEqual(2.0, order.GetBonus());
        }

        [TestMethod]
        public void GetBonusByLambdaParameter_Test()
        {
            // Use TenPercent lambda expresssion as parameter to GetBonus
            Assert.AreEqual(4.5, order.GetBonus((x) => x * 0.1));

            // Use FlatTwoIfAmountMoreThanFive lambda expresssion as parameter to GetBonus
            Assert.AreEqual(2.0, order.GetBonus((x) =>
            {
                if (x > 5)
                    x = 2.0;
                else x = 0.0;

                return x;
            }));
        }

        [TestMethod]
    	public void GetTotalPriceByLambdaParameter_Test()
    	{
        	Assert.AreEqual(40.5, order.GetTotalPrice((x) => x * 0.1));
 
        	Assert.AreEqual(43.0, order.GetTotalPrice((x) =>
            {
                if (x > 5)
                    x = 2.0;
                else x = 0.0;

                return x;
            }));
    	}
    }

}