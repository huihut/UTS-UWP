using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UTS_UWP.Convert
{
    public class ObjectToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                if (value != null)
                {
                    return value.ToString();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("ObjectToString Convert : " + e.Message.ToString());
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
