using Domain.ValueObject;

namespace Domain
{
        public interface ITotalAmount
        {
            void TotalAmountObserver(string totalAmount);
        }
    public class Cashbox
    {

        private readonly ITotalAmount IListener;
        public static int BundleCount = 50;
        private MoneyCategory oneYen = new MoneyCategory(1);
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
        public int OtherMoney1;
        public int OtherMoney2;
        public int OtherMoney3;
        public int OtherMoney4;
        public int OtherMoney5;
        public int OtherMoney6;
        public int OtherMoney7;
        public int OtherMoney8;

        public MoneyCategory OneYen
        {
            get => oneYen;
            set
           {
                oneYen = value;
                GetTotalAmountWithUnit();
            }
        }

        public void GetTotalAmountWithUnit()
        {
            IListener.TotalAmountObserver( $"{OneYen.Amount + FiveYen.Amount + TenYen.Amount + FiftyYen.Amount + OneHundredYen.Amount + FiveHundredYen.Amount + OneThousandYen.Amount + FiveThousandYen.Amount + TenThousandYen.Amount + OneYenBundle.Amount + FiveYenBundle.Amount + TenYenBundle.Amount + FiftyYenBundle.Amount + OneHundredYenBundle.Amount + FiveHundredYenBundle.Amount:N0} {Properties.Resources.MoneyUnit}");
        }
    }
}
