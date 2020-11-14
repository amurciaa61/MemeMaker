using System;
using System.Globalization;
using System.Windows.Data;

namespace MemeMaker
{
// Casteo value a bool y pregunto si es true. En ese caso devolveré una cadena con lo que espera 
// recibir el BorderThickness para mostrar el Border, en caso contrario devolveré 0 (Sin Margen).
// Podría devolver una cadena del tipo “2,5,7,0” con los cuatro lados del Margen(por ejemplo).
    class BorderSiNo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool && (bool)value)
                return "2";
            else
                return "0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
