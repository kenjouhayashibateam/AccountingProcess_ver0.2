using System;
using Domain;
using Domain.ValueObject;

namespace WPF.ViewModels
{
    /// <summary>
    /// 金庫金額計算ビューモデル
    /// </summary>
    public class RemainingMoneyCalculationViewModel : BaseViewModel, ITotalAmount
    {
        public void TotalAmountObserver(string totalAmount)
        {
            TotalAmount = totalAmount;  
        }
        private readonly Cashbox myCashBox=new Cashbox();

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
                myCashBox.TenThousandYen.Count = tenThousandYenCount;
                TenThousandYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.TenThousandYen, ref TenThousandYenAmount);
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
                myCashBox.FiveThousandYen.Count = fiveThousandYenCount;
                FiveThousandYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiveThousandYen, ref FiveThousandYenAmount);
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
                myCashBox.OneThousandYen.Count = oneThousandYenCount;
                OneThousandYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.OneThousandYen, ref OneThousandYenAmount);
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
                myCashBox.FiveHundredYen.Count = fiveHundredYenCount;
                FiveHundredYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiveHundredYen, ref FiveHundredYenAmount);
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
                myCashBox.OneHundredYen.Count = oneHundredYenCount;
                OneHundredYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.OneHundredYen, ref OneHundredYenAmount);
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
                myCashBox.FiftyYen.Count = fiftyYenCount;
                FiftyYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiftyYen, ref FiftyYenAmount);
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
                myCashBox.TenYen.Count = tenYenCount;
                TenYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.TenYen, ref TenYenAmount);
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
                myCashBox.FiveYen.Count = fiveYenCount;
                FiveYenAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiveYen,ref FiveYenAmount);
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
                myCashBox.OneYen.Count = oneYenCount;
                OneYenAmountWithUnit= SetProperty_ReturnAmountWithUnit(myCashBox.OneYen,ref OneYenAmount);
                CallPropertyChanged();
            }
        }

        /// <summary>
        /// 指定した金種Amountに値をセットし、表示用金額文字列を返します。
        /// </summary>
        /// <param name="moneyCategory">金種</param>
        /// <param name="amountField">セットする金額フィールド</param>
        /// <returns></returns>
        private string SetProperty_ReturnAmountWithUnit(MoneyCategory moneyCategory,ref int amountField)
        {
            amountField = moneyCategory.Amount;
            return moneyCategory.AmountWithUnit();
        }


        /// <summary>
        /// 表示用の金額を文字列で返します。
        /// </summary>
        /// <param name="moneyAmount">金額</param>
        /// <returns></returns>
        private string ReturnAmountWithUnit(int moneyAmount) => $"{moneyAmount:N0} 円";

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
                myCashBox.FiveHundredYenBundle.Count = fiveHundredYenBundleCount;
                FiveHundredYenBundleAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiveHundredYenBundle, ref FiveHundredYenBundleAmount);
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
                myCashBox.OneHundredYenBundle.Count = oneHundredYenBundleCount;
                OneHundredYenBundleAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.OneHundredYenBundle, ref OneHundredYenBundleAmount);
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
                myCashBox.FiftyYenBundle.Count = fiftyYenBundleCount;
                fiftyYenBundleAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiftyYenBundle, ref FiftyYenBundleAmount);
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
                myCashBox.TenYenBundle.Count = tenYenBundleCount;
                TenYenBundleAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.TenYenBundle, ref TenYenBundleAmount);
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
                myCashBox.FiveYenBundle.Count = fiveYenBundleCount;
                FiveYenBundleAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.FiveYenBundle, ref FiveYenBundleAmount);
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
                myCashBox.OneYenBundle.Count = oneYenBundleCount;
                OneYenBundleAmountWithUnit = SetProperty_ReturnAmountWithUnit(myCashBox.OneYenBundle, ref OneYenBundleAmount);
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
        /// その他金庫の金額プロパティをセットします
        /// </summary>
        /// <param name="value">ビューからの文字列</param>
        /// <param name="otherMoneyAmount">金額</param>
        /// <param name="otherMoneyAmountDisplayValue">表示用金額</param>
        private void SetOtherMoneyAmount(string value, ref int otherMoneyAmount,ref string otherMoneyAmountDisplayValue)
        {
            if(!int.TryParse(value,out otherMoneyAmount))
            {
                otherMoneyAmount = 0;
                otherMoneyAmountDisplayValue = "";
            }
            else
            {
                otherMoneyAmountDisplayValue = otherMoneyAmount.ToString("N0");
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
                SetOtherMoneyAmount(value, ref OtherMoneyAmount1, ref otherMoneyAmountDisplayValue1);
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

        public string OtherMoneyAmountDisplayValue2
        {
            get => otherMoneyAmountDisplayValue2;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount2, ref otherMoneyAmountDisplayValue2);
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle3
        {
            get => otherMoneyTitle3;
            set
            {
                otherMoneyTitle3 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue3
        {
            get => otherMoneyAmountDisplayValue3;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount3, ref otherMoneyAmountDisplayValue3);
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle4
        {
            get => otherMoneyTitle4;
            set
            {
                otherMoneyTitle4 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue4
        {
            get => otherMoneyAmountDisplayValue4;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount4, ref otherMoneyAmountDisplayValue4);
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle5
        {
            get => otherMoneyTitle5;
            set
            {
                otherMoneyTitle5 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue5
        {
            get => otherMoneyAmountDisplayValue5;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount5, ref otherMoneyAmountDisplayValue5);
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle6
        {
            get => otherMoneyTitle6;
            set
            {
                otherMoneyTitle6 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue6
        {
            get => otherMoneyAmountDisplayValue6;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount6, ref otherMoneyAmountDisplayValue6);
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle7
        {
            get => otherMoneyTitle7;
            set
            {
                otherMoneyTitle7 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue7
        {
            get => otherMoneyAmountDisplayValue7;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount7, ref otherMoneyAmountDisplayValue7);
                CallPropertyChanged();
            }
        }

        public string OtherMoneyTitle8
        {
            get => otherMoneyTitle8;
            set
            {
                otherMoneyTitle8 = value;
                CallPropertyChanged();
            }
        }

        public string OtherMoneyAmountDisplayValue8
        {
            get => otherMoneyAmountDisplayValue8;
            set
            {
                SetOtherMoneyAmount(value, ref OtherMoneyAmount8, ref otherMoneyAmountDisplayValue8);
                CallPropertyChanged();
            }
        }

        private string otherMoneyAmountDisplayValue1;
        private string otherMoneyAmountDisplayValue2;
        private string otherMoneyAmountDisplayValue3;
        private string otherMoneyAmountDisplayValue4;
        private string otherMoneyAmountDisplayValue5;
        private string otherMoneyAmountDisplayValue6;
        private string otherMoneyAmountDisplayValue7;
        private string otherMoneyAmountDisplayValue8;
        private string otherMoneyTitle1="青蓮堂";
        private string otherMoneyTitle2="香華売り場";
        private string otherMoneyTitle3;
        private string otherMoneyTitle4;
        private string otherMoneyTitle5;
        private string otherMoneyTitle6;
        private string otherMoneyTitle7;
        private string otherMoneyTitle8;
        private int OtherMoneyAmount1;
        private int OtherMoneyAmount2;
        private int OtherMoneyAmount3;
        private int OtherMoneyAmount4;
        private int OtherMoneyAmount5;
        private int OtherMoneyAmount6;
        private int OtherMoneyAmount7;
        private int OtherMoneyAmount8;
    }
}
