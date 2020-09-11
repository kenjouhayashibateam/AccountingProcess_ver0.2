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
                FiveHundredYenBundleCount=10
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
            
            Assert.AreEqual(vm.TotalAmount, "499,660 â~");
        }
        [TestMethod]
        public void ÇªÇÃëºã‡å…ÇÃã‡äzóìÇ™êîéöÇ©Ç«Ç§Ç©()
        {
            var vm = new RemainingMoneyCalculationViewModel
            {
                OtherMoneyAmountDisplayValue1 = "a"
            };
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue1, "");

            vm.OtherMoneyAmountDisplayValue1 = "1000";
            Assert.AreEqual(vm.OtherMoneyAmountDisplayValue1, "1,000");
        }
    }
}
