namespace WPF.ViewModels
{
    public class RemainingMoneyCalculationViewModel:BaseViewModel
    {
         public int TenThousandYenCount
        {
            get => tenThousandYenCount;
            set
            {
                tenThousandYenCount = value;
                TenThousandYenAmount = value * 10000;
                TenThousandYenAmountWithUnit = $"{TenThousandYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }
   
        public int FiveThousandYenCount
        {
            get => fiveThousandYenCount;
            set
            {
                fiveThousandYenCount = value;
                FiveThousandYenAmount = value * 5000;
                FiveThousandYenAmountWithUnit = $"{FiveThousandYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public int OneThousandYenCount
        {
            get => oneThousandYenCount;
            set
            {
                oneThousandYenCount = value;
                OneThousandYenAmount = value * 1000;
                OneThousandYenAmountWithUnit = $"{OneThousandYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public int FiveHundredYenCount
        {
            get => fiveHundredYenCount;
            set
            {
                fiveHundredYenCount = value;
                FiveHundredYenAmount = value * 500;
                FiveHundredYenAmountWithUnit = $"{FiveHundredYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }


        public int OneHundredYenCount
        {
            get => oneHundredYenCount;
            set
            {
                oneHundredYenCount = value;
                OneHundredYenAmount = value * 100;
                OneHundredYenAmountWithUnit = $"{OneHundredYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }
             

        public int FiftyYenCount
        {
            get => fiftyYenCount;
            set
            {
                fiftyYenCount = value;
                FiftyYenAmount = value * 50;
                FiftyYenAmountWithUnit = $"{FiftyYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }
  
        public int TenYenCount
        {
            get => tenYenCount;
            set
            {
                tenYenCount = value;
                TenYenAmount = value * 10;
                TenYenAmountWithUnit = $"{TenYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public int FiveYenCount
        {
            get => fiveYenCount;
            set
            {
                fiveYenCount = value;
                FiveYenAmount = value * 5;
                FiveYenAmountWithUnit = $"{FiveYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public int OneYenCount
        {
            get => oneYenCount;
            set
            {
                oneYenCount = value;
                OneYenAmount = value * 1;
                OneYenAmountWithUnit = $"{OneYenAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string TenThousandYenAmountWithUnit
        {
            get => tenThousandYenAmountWithUnit;
            set
            {
                tenThousandYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string FiveThousandYenAmountWithUnit
        {
            get => fiveThousandYenAmountWithUnit;
            set
            {
                fiveThousandYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string OneThousandYenAmountWithUnit
        {
            get => oneThousandYenAmountWithUnit;
            set
            {
                oneThousandYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string FiveHundredYenAmountWithUnit
        {
            get => fiveHundredYenAmountWithUnit;
            set
            {
                fiveHundredYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string OneHundredYenAmountWithUnit
        {
            get => oneHundredYenAmountWithUnit;
            set
            {
                oneHundredYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string TenYenAmountWithUnit
        {
            get => tenYenAmountWithUnit;
            set
            {
                tenYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string FiveYenAmountWithUnit
        {
            get => fiveYenAmountWithUnit;
            set
            {
                fiveYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string OneYenAmountWithUnit
        {
            get => oneYenAmountWithUnit;
            set
            {
                oneYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public string FiftyYenAmountWithUnit
        {
            get => fiftyYenAmountWithUnit;
            set
            {
                fiftyYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }
            
        private int OneYenAmount;
        private int FiveYenAmount;
        private int TenYenAmount;
        private int FiftyYenAmount;
        private int OneHundredYenAmount;
        private int FiveHundredYenAmount;
        private int OneThousandYenAmount;
        private int FiveThousandYenAmount;
        private int TenThousandYenAmount;
        private int FiveHundredYenBundleAmount;
        private int OneHundredYenBundleAmount;
        private int FiftyYenBundleAmount;
        private int TenYenBundleAmount;
        private int FiveYenBundleAmount;
        private int OneYenBundleAmount;

        public string TotalAmount
        {
            get => totalAmount;
            set
            {
                totalAmount = value;
                CallPropertyChanged();
            }
        }

        public int FiveHundredYenBundleCount
        {
            get => fiveHundredYenBundleCount;
            set
            {
                fiveHundredYenBundleCount = value;
                FiveHundredYenBundleAmount = value * 500 * 50;
                FiveHundredYenBundleAmountWithUnit = $"{FiveHundredYenBundleAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string FiveHundredYenBundleAmountWithUnit
        {
            get => fiveHundredYenBundleAmountWithUnit;
            set
            {
                fiveHundredYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public int OneHundredYenBundleCount
        {
            get => oneHundredYenBundleCount;
            set
            {
                oneHundredYenBundleCount = value;
                OneHundredYenBundleAmount = value * 100 * 50;
                OneHundredYenBundleAmountWithUnit = $"{OneHundredYenBundleAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string OneHundredYenBundleAmountWithUnit
        {
            get => oneHundredYenBundleAmountWithUnit;
            set
            {
                oneHundredYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public int FiftyYenBundleCount
        {
            get => fiftyYenBundleCount;
            set
            {
                fiftyYenBundleCount = value;
                FiftyYenBundleAmount = value * 50 * 50;
                FiftyYenBundleAmountWithUnit = $"{FiftyYenBundleAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string FiftyYenBundleAmountWithUnit
        {
            get => fiftyYenBundleAmountWithUnit;
            set
            {
                fiftyYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public int TenYenBundleCount
        {
            get => tenYenBundleCount;
            set
            {
                tenYenBundleCount = value;
                TenYenBundleAmount = value * 10 * 50;
                TenYenBundleAmountWithUnit = $"{TenYenBundleAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string TenYenBundleAmountWithUnit
        {
            get => tenYenBundleAmountWithUnit;
            set
            {
                tenYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public int FiveYenBundleCount
        {
            get => fiveYenBundleCount;
            set
            {
                fiveYenBundleCount = value;
                FiveYenBundleAmount = value * 5 * 50;
                FiveYenBundleAmountWithUnit = $"{FiveYenBundleAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string FiveYenBundleAmountWithUnit
        {
            get => fiveYenBundleAmountWithUnit;
            set
            {
                fiveYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        public int OneYenBundleCount
        {
            get => oneYenBundleCount;
            set
            {
                oneYenBundleCount = value;
                OneYenBundleAmount = value * 1 * 50;
                OneYenBundleAmountWithUnit = $"{OneYenBundleAmount:N0} 円";
                SetTotalAmount();
                CallPropertyChanged();
            }
        }

        public string OneYenBundleAmountWithUnit
        {
            get => oneYenBundleAmountWithUnit;
            set
            {
                oneYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        private string oneYenBundleAmountWithUnit;
        private int oneYenBundleCount;
        private string fiveYenBundleAmountWithUnit;
        private int fiveYenBundleCount;
        private string tenYenBundleAmountWithUnit;
        private int tenYenBundleCount;
        private string fiftyYenBundleAmountWithUnit;
        private int fiftyYenBundleCount;
        private string oneHundredYenBundleAmountWithUnit;
        private int oneHundredYenBundleCount;
        private string fiveHundredYenBundleAmountWithUnit;
        private int fiveHundredYenBundleCount;
        private string oneYenAmountWithUnit;
        private string tenThousandYenAmountWithUnit;
        private string fiveThousandYenAmountWithUnit;
        private string oneThousandYenAmountWithUnit;
        private string fiveHundredYenAmountWithUnit;
        private string oneHundredYenAmountWithUnit;
        private string tenYenAmountWithUnit;
        private string fiveYenAmountWithUnit;
        private int oneYenCount;
        private int fiveYenCount;
        private string fiftyYenAmountWithUnit;
        private int tenYenCount;
        private int fiftyYenCount;
        private int oneHundredYenCount;
        private int fiveHundredYenCount;
        private int tenThousandYenCount;
        private int fiveThousandYenCount;
        private int oneThousandYenCount;
        private string totalAmount;
    
        private void SetTotalAmount()
        {
            int I = OneYenAmount + FiveYenAmount + TenYenAmount + FiftyYenAmount + OneHundredYenAmount + FiveHundredYenAmount + OneThousandYenAmount + FiveThousandYenAmount + TenThousandYenAmount+FiveHundredYenBundleAmount+
                OneHundredYenBundleAmount+FiftyYenBundleAmount+TenYenBundleAmount+FiveYenBundleAmount+OneYenBundleAmount;
            TotalAmount = $"{I:N0} 円" ;
        }
    }
}
