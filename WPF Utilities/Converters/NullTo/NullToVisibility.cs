using System.Windows.Data;
using System.Windows;
using System;
using System.Windows.Markup;

namespace WPFUtilities.Converters.NullTo
{
    public class NullToVisibility : MarkupExtension, IValueConverter
    {
        public Visibility NotNullVisibility { get; set; } = Visibility.Visible;
        public Visibility NullVisibility { get; set; } = Visibility.Collapsed;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value is not null) ? NotNullVisibility : NullVisibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
