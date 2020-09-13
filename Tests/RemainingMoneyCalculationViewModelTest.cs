using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;
using WPF.ViewModels;

namespace Tests
{
    [TestClass]
    public class RemainingMoneyCalculationViewModelTest
    {
        [TestMethod]
        public void ÉVÉiÉäÉI()
        {
            var vm = new RemainingMoneyCalculationViewModel
            {
                OneYenCount = 10,
                FiveYenCount = 10,
                TenYenCount=10,
                FiftyYenCount=10,
                OneHundredYenCount=10,
                FiveHundredYenCount=10,
                OneThousandYenCount=10,
                FiveThousandYenCount=10,
                TenThousandYenCount=10,
                OneYenBundleCount=10,
                FiveYenBundleCount=10,
                TenYenBundleCount=10,
                FiftyYenBundleCount=10,
                OneHundredYenBundleCount=10,
                FiveHundredYenBundleCount=10,
                OtherMoneyAmountDisplayValue1="10",
                OtherMoneyAmountDisplayValue2 = "10",
                OtherMoneyAmountDisplayValue3 = "10",
                OtherMoneyAmountDisplayValue4 = "10",
                OtherMoneyAmountDisplayValue5 = "10",
                OtherMoneyAmountDisplayValue6 = "10",
                OtherMoneyAmountDisplayValue7 = "10",
                OtherMoneyAmountDisplayValue8 = "10",
            };
            
            Assert.AreEqual(vm.OneYenAmountWithUnit, "10 â~");
            Assert.AreEqual(vm.FiveYenAmountWithUnit, "50 â~");
            Assert.AreEqual(vm.TenYenAmountWithUnit, "100 â~");
            Assert.AreEqual(vm.FiftyYenAmountWithUnit, "500 â~");
            Assert.AreEqual(vm.OneHundredYenAmountWithUnit, "1,000 â~");
            Assert.AreEqual(vm.FiveHundredYenAmountWithUnit, "5,000 â~");
            Assert.AreEqual(vm.OneThousandYenAmountWithUnit, "10,000 â~");
            Assert.AreEqual(vm.FiveThousandYenAmountWithUnit, "50,000 â~");
            Assert.AreEqual(vm.TenThousandYenAmountWithUnit, "100,000 â~");
            Assert.AreEqual(vm.OneYenBundleAmountWithUnit, "500 â~");
            Assert.AreEqual(vm.FiveYenBundleAmountWithUnit, "2,500 â~");
            Assert.AreEqual(vm.TenYenBundleAmountWithUnit, "5,000 â~");
            Assert.AreEqual(vm.FiftyYenBundleAmountWithUnit, "25,000 â~");
            Assert.AreEqual(vm.OneHundredYenBundleAmountWithUnit, "50,000 â~");
            Assert.AreEqual(vm.FiveHundredYenBundleAmountWithUnit, "250,000 â~");
            
            Assert.AreEqual(vm.TotalAmount, "499,740 â~");
        }

        [TestMethod]
        public void ÇªÇÃëºã‡å…ÇÃã‡äzóìÇ™êîéöÇ©Ç«Ç§Ç©()
        {
            var vm = new RemainingMoneyCalculationViewModel
            {
                OtherMoneyAmountDisplayValue1 = "a",
                OtherMoneyAmountDisplayValue2 = "a",
                OtherMoneyAmountDisplayValue3 = "a",
                OtherMoneyAmountDisplayValue4 = "a",
                OtherMoneyAmountDisplayValue5 = "a",
                OtherMoneyAmountDisplayValue6 = "a",
                OtherMoneyAmountDisplayValue7 = "a",
                OtherMoneyAmountDisplayValue8 = "a",
            };
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue1, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue2, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue3, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue4, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue5, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue6, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue7, "");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue8, "");

            vm.OtherMoneyAmountDisplayValue1 = "1000";
            vm.OtherMoneyAmountDisplayValue2 = "1000";
            vm.OtherMoneyAmountDisplayValue3 = "1000";
            vm.OtherMoneyAmountDisplayValue4 = "1000";
            vm.OtherMoneyAmountDisplayValue5 = "1000";
            vm.OtherMoneyAmountDisplayValue6 = "1000";
            vm.OtherMoneyAmountDisplayValue7 = "1000";
            vm.OtherMoneyAmountDisplayValue8 = "1000";
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue1, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue2, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue3, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue4, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue5, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue6, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue7, "1,000");
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue8, "1,000");
        }
    }
}
