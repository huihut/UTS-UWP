using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace UTS_UWP.Convert
{
    public class NumberToImage : IValueConverter
    {
        private static BitmapImage[] numbers;
        static NumberToImage()
        {
            try
            {
                BitmapImage[] numbersTemp =
                   {
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number1.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number2.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number3.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number4.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number5.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number6.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number7.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number8.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number9.png")),
                        new BitmapImage(new Uri(@"ms-appx:///Assets/Number/number10.png"))
                    };
                numbers = numbersTemp;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("NumberToImage NumberToImage : " + e.Message.ToString());
            }
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                if (value != null)
                {
                    int level = System.Convert.ToInt32(value.ToString());
                    switch (level)
                    {
                        case 1: return numbers[0];
                        case 2: return numbers[1];
                        case 3: return numbers[2];
                        case 4: return numbers[3];
                        case 5: return numbers[4];
                        case 6: return numbers[5];
                        case 7: return numbers[6];
                        case 8: return numbers[7];
                        case 9: return numbers[8];
                        case 10: return numbers[9];
                        default: return null;
                    }
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("NumberToImage Convert : " + e.Message.ToString());
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
