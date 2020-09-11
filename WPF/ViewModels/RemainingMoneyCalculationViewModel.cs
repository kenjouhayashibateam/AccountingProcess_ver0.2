namespace WPF.ViewModels
{
    /// <summary>
    /// 金庫金額計算ビューモデル
    /// </summary>
    public class RemainingMoneyCalculationViewModel:BaseViewModel
    {
        //表示用金額
        private string oneYenBundleAmountWithUnit;
        private string fiveYenBundleAmountWithUnit;
        private string tenYenBundleAmountWithUnit;
        private string fiftyYenBundleAmountWithUnit;
        private string oneHundredYenBundleAmountWithUnit;
        private string fiveHundredYenBundleAmountWithUnit;
        private string oneYenAmountWithUnit;
        private string tenThousandYenAmountWithUnit;
        private string fiveThousandYenAmountWithUnit;
        private string oneThousandYenAmountWithUnit;
        private string fiveHundredYenAmountWithUnit;
        private string oneHundredYenAmountWithUnit;
        private string tenYenAmountWithUnit;
        private string fiveYenAmountWithUnit;
        //金銭数量
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
        private int oneYenBundleCount;
        private int fiveYenBundleCount;
        private int tenYenBundleCount;
        private int fiftyYenBundleCount;
        private int oneHundredYenBundleCount;
        private int fiveHundredYenBundleCount;
        //単体金銭金額
        private int OneYenAmount;
        private int FiveYenAmount;
        private int TenYenAmount;
        private int FiftyYenAmount;
        private int OneHundredYenAmount;
        private int FiveHundredYenAmount;
        private int OneThousandYenAmount;
        private int FiveThousandYenAmount;
        private int TenThousandYenAmount;
        //束金銭金額
        private int FiveHundredYenBundleAmount;
        private int OneHundredYenBundleAmount;
        private int FiftyYenBundleAmount;
        private int TenYenBundleAmount;
        private int FiveYenBundleAmount;
        private int OneYenBundleAmount;
        //総金額
        private string totalAmount;

        /// <summary>
        /// 1万円札の枚数
        /// </summary>
         public int TenThousandYenCount
        {
            get => tenThousandYenCount;
            set
            {
                tenThousandYenCount = value;
                SetMoney(10000, value, ref TenThousandYenAmount);
                TenThousandYenAmountWithUnit = ReturnAmountWithUnit(TenThousandYenAmount);
                CallPropertyChanged();
            }
        }
   
        /// <summary>
        /// 5千円札の枚数
        /// </summary>
        public int FiveThousandYenCount
        {
            get => fiveThousandYenCount;
            set
            {
                fiveThousandYenCount = value;
                SetMoney(5000, value, ref FiveThousandYenAmount);
                FiveThousandYenAmountWithUnit = ReturnAmountWithUnit(FiveThousandYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 千円札の枚数
        /// </summary>
        public int OneThousandYenCount
        {
            get => oneThousandYenCount;
            set
            {
                oneThousandYenCount = value;
                SetMoney(1000, value, ref OneThousandYenAmount);
                OneThousandYenAmountWithUnit = ReturnAmountWithUnit(OneThousandYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 500円玉の枚数
        /// </summary>
        public int FiveHundredYenCount
        {
            get => fiveHundredYenCount;
            set
            {
                fiveHundredYenCount = value;
                SetMoney(500, value, ref FiveHundredYenAmount);
                FiveHundredYenAmountWithUnit = ReturnAmountWithUnit(FiveHundredYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 100円玉の枚数
        /// </summary>
        public int OneHundredYenCount
        {
            get => oneHundredYenCount;
            set
            {
                oneHundredYenCount = value;
                SetMoney(100, value, ref OneHundredYenAmount);
                OneHundredYenAmountWithUnit = ReturnAmountWithUnit(OneHundredYenAmount);
                CallPropertyChanged();
            }
        }
             
        /// <summary>
        /// 50円玉の枚数
        /// </summary>
        public int FiftyYenCount
        {
            get => fiftyYenCount;
            set
            {
                fiftyYenCount = value;
                SetMoney(50, value, ref FiftyYenAmount);
                FiftyYenAmountWithUnit = ReturnAmountWithUnit(FiftyYenAmount);
                CallPropertyChanged();
            }
        }
  
        /// <summary>
        /// 10円玉の枚数
        /// </summary>
        public int TenYenCount
        {
            get => tenYenCount;
            set
            {
                tenYenCount = value;
                SetMoney(10, value, ref TenYenAmount);
                TenYenAmountWithUnit =ReturnAmountWithUnit(TenYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 5円玉の枚数
        /// </summary>
        public int FiveYenCount
        {
            get => fiveYenCount;
            set
            {
                fiveYenCount = value;
                SetMoney(5, value, ref FiveYenAmount);
                FiveYenAmountWithUnit = ReturnAmountWithUnit(FiveYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 1円玉の枚数
        /// </summary>
        public int OneYenCount
        {
            get => oneYenCount;
            set
            {
                oneYenCount = value;
                SetMoney(1, oneYenCount, ref OneYenAmount);
                OneYenAmountWithUnit = ReturnAmountWithUnit(OneYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用の金額を文字列で返します。
        /// </summary>
        /// <param name="moneyAmount">金額</param>
        /// <returns></returns>
        private string ReturnAmountWithUnit(int moneyAmount)
        {
            return $"{moneyAmount:N0} 円";
        }

        /// <summary>
        /// 入力された数量を各プロパティにセットします。
        /// </summary>
        /// <param name="denomination">金種</param>
        /// <param name="moneyCount">金銭の数量</param>
        /// <param name="moneyAmount">金額（数字のみ）</param>
        /// <param name="amountWithUnit">金額（表示用）</param>
        private void SetMoney(int denomination,int moneyCount,ref int moneyAmount)
        {
            moneyAmount = denomination * moneyCount;
            SetTotalAmount();
        }

        /// <summary>
        /// 表示用一万円札合計金額
        /// </summary>
        public string TenThousandYenAmountWithUnit
        {
            get => tenThousandYenAmountWithUnit;
            set
            {
                tenThousandYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用5千円札合計金額
        /// </summary>
        public string FiveThousandYenAmountWithUnit
        {
            get => fiveThousandYenAmountWithUnit;
            set
            {
                fiveThousandYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用千円札合計金額
        /// </summary>
        public string OneThousandYenAmountWithUnit
        {
            get => oneThousandYenAmountWithUnit;
            set
            {
                oneThousandYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用500円玉合計金額
        /// </summary>
        public string FiveHundredYenAmountWithUnit
        {
            get => fiveHundredYenAmountWithUnit;
            set
            {
                fiveHundredYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用100円玉合計金額
        /// </summary>
        public string OneHundredYenAmountWithUnit
        {
            get => oneHundredYenAmountWithUnit;
            set
            {
                oneHundredYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用10円玉合計金額
        /// </summary>
        public string TenYenAmountWithUnit
        {
            get => tenYenAmountWithUnit;
            set
            {
                tenYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用5円玉合計金額
        /// </summary>
        public string FiveYenAmountWithUnit
        {
            get => fiveYenAmountWithUnit;
            set
            {
                fiveYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 1円玉合計金額
        /// </summary>
        public string OneYenAmountWithUnit
        {
            get => oneYenAmountWithUnit;
            set
            {
                oneYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 50円玉合計金額
        /// </summary>
        public string FiftyYenAmountWithUnit
        {
            get => fiftyYenAmountWithUnit;
            set
            {
                fiftyYenAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用総金額
        /// </summary>
        public string TotalAmount
        {
            get => totalAmount;
            set
            {
                totalAmount = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 500円玉束数量
        /// </summary>
        public int FiveHundredYenBundleCount
        {
            get => fiveHundredYenBundleCount;
            set
            {
                fiveHundredYenBundleCount = value;
                SetMoney(25000, value, ref FiveHundredYenBundleAmount);
                FiveHundredYenBundleAmountWithUnit = ReturnAmountWithUnit(FiveHundredYenBundleAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用500円玉束合計金額
        /// </summary>
        public string FiveHundredYenBundleAmountWithUnit
        {
            get => fiveHundredYenBundleAmountWithUnit;
            set
            {
                fiveHundredYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 100円玉束数量
        /// </summary>
        public int OneHundredYenBundleCount
        {
            get => oneHundredYenBundleCount;
            set
            {
                oneHundredYenBundleCount = value;
                SetMoney(5000,value,ref OneHundredYenBundleAmount);
                OneHundredYenBundleAmountWithUnit = ReturnAmountWithUnit(OneHundredYenBundleAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用100円玉束合計金額
        /// </summary>
        public string OneHundredYenBundleAmountWithUnit
        {
            get => oneHundredYenBundleAmountWithUnit;
            set
            {
                oneHundredYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 50円玉束数量
        /// </summary>
        public int FiftyYenBundleCount
        {
            get => fiftyYenBundleCount;
            set
            {
                fiftyYenBundleCount = value;
                SetMoney(2500,value,ref FiftyYenBundleAmount);
                FiftyYenBundleAmountWithUnit =ReturnAmountWithUnit(FiftyYenBundleAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用50円玉束合計金額
        /// </summary>
        public string FiftyYenBundleAmountWithUnit
        {
            get => fiftyYenBundleAmountWithUnit;
            set
            {
                fiftyYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 10円玉束数量
        /// </summary>
        public int TenYenBundleCount
        {
            get => tenYenBundleCount;
            set
            {
                tenYenBundleCount = value;
                SetMoney(500,value,ref TenYenBundleAmount);
                TenYenBundleAmountWithUnit = ReturnAmountWithUnit(TenYenBundleAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用10円玉束合計金額
        /// </summary>
        public string TenYenBundleAmountWithUnit
        {
            get => tenYenBundleAmountWithUnit;
            set
            {
                tenYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 5円玉束数量
        /// </summary>
        public int FiveYenBundleCount
        {
            get => fiveYenBundleCount;
            set
            {
                fiveYenBundleCount = value;
                SetMoney(250,value,ref FiveYenBundleAmount);
                FiveYenBundleAmountWithUnit = ReturnAmountWithUnit(FiveYenBundleAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用5円玉束合計金額
        /// </summary>
        public string FiveYenBundleAmountWithUnit
        {
            get => fiveYenBundleAmountWithUnit;
            set
            {
                fiveYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 1円玉束数量
        /// </summary>
        public int OneYenBundleCount
        {
            get => oneYenBundleCount;
            set
            {
                oneYenBundleCount = value;
                SetMoney(50,value,ref OneYenBundleAmount);
                OneYenBundleAmountWithUnit = ReturnAmountWithUnit(OneYenBundleAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 表示用1円玉束合計金額
        /// </summary>
        public string OneYenBundleAmountWithUnit
        {
            get => oneYenBundleAmountWithUnit;
            set
            {
                oneYenBundleAmountWithUnit = value;
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// その他金庫等1
        /// </summary>
        public string OtherMoneyTitle1
        {
            get => otherMoneyTitle1;
            set
            {
                otherMoneyTitle1 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue1
        {
            get => otherMoneyAmountDisplayValue1;
            set
            {
                if (!int.TryParse(value, out OtherMoneyAmount1))
                {
                    OtherMoneyAmount1 = 0;
                    otherMoneyAmountDisplayValue1 = "";
                }
                else
                {
                    otherMoneyAmountDisplayValue1 = OtherMoneyAmount1.ToString("N0");
                    SetTotalAmount();
                }
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle2
        {
            get => otherMoneyTitle2;
            set
            {
                otherMoneyTitle2 = value;
                CallPropertyChanged();
            }
        }

        private string otherMoneyTitle2="香華売り場";
        private int OtherMoneyAmount1;
        private string otherMoneyTitle1="青蓮堂";
        private string otherMoneyAmountDisplayValue1;
        /// <summary>
        /// 総金額を計算します。
        /// </summary>
        private void SetTotalAmount()
        {
            int I = OneYenAmount + FiveYenAmount + TenYenAmount + FiftyYenAmount + OneHundredYenAmount + FiveHundredYenAmount + OneThousandYenAmount + FiveThousandYenAmount + TenThousandYenAmount+FiveHundredYenBundleAmount+
                OneHundredYenBundleAmount+FiftyYenBundleAmount+TenYenBundleAmount+FiveYenBundleAmount+OneYenBundleAmount+OtherMoneyAmount1;
            TotalAmount = ReturnAmountWithUnit(I);
        }
    }
}
