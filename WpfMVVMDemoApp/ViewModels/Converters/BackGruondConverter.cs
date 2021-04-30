using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfMVVMDemoApp.ViewModels.Converters
{
    internal class BackGruondConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "Male")
                {
                    return new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color()
                    {
                        A = 255,
                        R = 70,
                        G = 161,
                        B = 255
                    });

                }
                else
                {
                    return new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color()
                    {
                        A = 255,
                        R = 216,
                        G = 0,
                        B = 115
                    });
                }
            }
            return null;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
