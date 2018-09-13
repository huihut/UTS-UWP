using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UTS_UWP.Convert
{
    public class IntToVisible : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                if (parameter == null && value != null)
                {
                    return int.Parse(value.ToString()) > 0 ? Visibility.Visible : Visibility.Collapsed;
                }
                else if (parameter != null && parameter.ToString() == "-" && value != null)
                {
                    return int.Parse(value.ToString()) > 0 ? Visibility.Collapsed : Visibility.Visible;
                }
                else if (parameter != null && value != null)
                {
                    return parameter.ToString() == value.ToString() ? Visibility.Visible : Visibility.Collapsed;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("IntToVisible Convert : " + e.Message.ToString());
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
