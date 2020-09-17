using Domain.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Cashbox
    { 
        public static int BundleCount = 50;
        public MoneyCategory OneYen = new MoneyCategory(1);
        public MoneyCategory FiveYen = new MoneyCategory(5);
        public MoneyCategory TenYen = new MoneyCategory(10);
        public MoneyCategory FiftyYen = new MoneyCategory(50);
        public MoneyCategory OneHundredYen = new MoneyCategory(100);
        public MoneyCategory FiveHundredYen = new MoneyCategory(500);
        public MoneyCategory OneThousandYen = new MoneyCategory(1000);
        public MoneyCategory FiveThousandYen = new MoneyCategory(5000);
        public MoneyCategory TenThousandYen = new MoneyCategory(10000);
        public MoneyCategory OneYenBundle = new MoneyCategory(1 * BundleCount);
        public MoneyCategory FiveYenBundle = new MoneyCategory(5 * BundleCount);
        public MoneyCategory TenYenBundle = new MoneyCategory(10 * BundleCount);
        public MoneyCategory FiftyYenBundle = new MoneyCategory(50 * BundleCount);
        public MoneyCategory OneHundredYenBundle = new MoneyCategory(100 * BundleCount);
        public MoneyCategory FiveHundredYenBundle = new MoneyCategory(500 * BundleCount);
        public int[] OtherMoneys=new int[8];
        public Dictionary<MoneyCategory.Denomination,MoneyCategory> MoneyCategorys =new Dictionary<MoneyCategory.Denomination,MoneyCategory>();

        public Cashbox()
        {
            MoneyCategorys.Add(MoneyCategory.Denomination.OneYen, new MoneyCategory(1));
        }

        public string GetTotalAmountWithUnit()
        {
            int I = OneYen.Amount + FiveYen.Amount + TenYen.Amount +
                FiftyYen.Amount + OneHundredYen.Amount + FiveHundredYen.Amount +
                OneThousandYen.Amount + FiveThousandYen.Amount + TenThousandYen.Amount +
                OneYenBundle.Amount + FiveYenBundle.Amount + TenYenBundle.Amount +
                FiftyYenBundle.Amount + OneHundredYenBundle.Amount + FiveHundredYenBundle.Amount +
                OtherMoneys.Sum();

            foreach (KeyValuePair<MoneyCategory.Denomination,MoneyCategory>mc in MoneyCategorys)
            {
                I += mc.Value.Amount;
            }

            return $"{I:N0} {Properties.Resources.MoneyUnit}";
        }
    }
}
