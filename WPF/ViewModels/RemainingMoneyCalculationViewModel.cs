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
                TenThousandYenAmountWithUnit = $"{value * 10000:N0)} 円";
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
      
        public int FiveThousandYenCount
        {
            get => fiveThousandYenCount;
            set
            {
                fiveThousandYenCount = value;
                FiveThousandYenAmountWithUnit = $"{value * 5000:N0} 円";
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

        public int OneThousandYenCount
        {
            get => oneThousandYenCount;
            set
            {
                oneThousandYenCount = value;
                OneThousandYenAmountWithUnit = $"{value*1000:N0} 円";
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
        
        private string tenThousandYenAmountWithUnit;
        private int tenThousandYenCount;
        private int fiveThousandYenCount;
        private string oneThousandYenAmountWithUnit;
        private string fiveThousandYenAmountWithUnit;
        private int oneThousandYenCount;

    }
}
