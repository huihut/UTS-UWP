using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UTS_UWP.Convert
{
    public class BoolToVisible : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                if (value != null)
                {
                    if (parameter != null && parameter.ToString() == "-")
                    {
                        return value.ToString() == false.ToString() ? Visibility.Visible : Visibility.Collapsed;
                    }
                    else
                    {
                        return value.ToString() == true.ToString() ? Visibility.Visible : Visibility.Collapsed;
                    }
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("BoolToVisible Convert : " + e.Message.ToString());
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
