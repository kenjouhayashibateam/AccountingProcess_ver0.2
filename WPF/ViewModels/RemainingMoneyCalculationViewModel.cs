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
                CallPropertyChanged();
            }
        }
             

        public int FiftyYenCount
        {
            get => fiftyYenCount;
            set
            {
                fiftyYenCount = value;

                FiftyYenAmountWithUnit = $"{value * 50:N0} 円";
                CallPropertyChanged();
            }
        }
  
        public int TenYenCount
        {
            get => tenYenCount;
            set
            {
                tenYenCount = value;
                TenYenAmountWithUnit = $"{value * 10:N0} 円";
                CallPropertyChanged();
            }
        }

        public int FiveYenCount
        {
            get => fiveYenCount;
            set
            {
                fiveYenCount = value;
                FiveYenAmountWithUnit = $"{value * 5:N0} 円";
                CallPropertyChanged();
            }
        }

        public int OneYenCount
        {
            get => oneYenCount;
            set
            {
                oneYenCount = value;
                OneYenAmountWithUnit = $"{value * 1:N0} 円";
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

        public int TotalAmount
        {
            get => totalAmount;
            set
            {
                totalAmount = value;
                CallPropertyChanged();
            }
        }

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
        private int totalAmount;
    }
}
