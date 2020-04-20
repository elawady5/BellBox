using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using System;


namespace BellBox.Helpers.ValueConverters
{
    public class ObjectToImageSourceConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var currentAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            string packUri = $"{System.IO.Path.GetDirectoryName(currentAssembly.Location)}{value}";
            IBitmap Source = new Bitmap(packUri);
            return Source;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
