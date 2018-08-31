using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;
using XamHelper.Guards;

namespace XamHelper.Converters
{
    public class ByteArrayToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Guard.ThrowIfNull(value, "Image byteArray");
            var array = (byte[]) value;
            return ImageSource.FromStream((() => new MemoryStream(array)));

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}