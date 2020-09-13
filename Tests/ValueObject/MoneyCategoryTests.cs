using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

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
            Assert.AreEqual(money.AmountWithUnit(), "1,000 円");
        }
    }
}