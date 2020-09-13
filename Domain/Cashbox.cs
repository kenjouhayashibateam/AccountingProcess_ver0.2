using Domain.ValueObject;

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
        
        
    }
}
