using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeExpenseUI.Datbase
{
    public class LoacalCulture
    {
        static string cultureString;
        LoacalCulture(string countryName)
        {
          
        }


        public static string GetCurrancySymbol()
        {
            return CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol;
        }
    }
}
