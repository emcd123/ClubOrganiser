using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ClubOrganiser.Utils
{
    public class FontConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fontName = value as string;
            if (!Application.Current.Resources.ContainsKey(fontName))
                throw new KeyNotFoundException($"{fontName} not found in resources");
            return (string)Application.Current.Resources[fontName];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
