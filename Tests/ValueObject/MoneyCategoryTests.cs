using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domain.ValueObject.Tests
{
    [TestClass()]
    public class MoneyCategoryTests
    {
        [TestMethod()]
        public void シナリオ()
        {
            var money = new MoneyCategory(100)
            {
                Count = 10
            };

            Assert.AreEqual(money.Amount, 1000);
        }
    }
}