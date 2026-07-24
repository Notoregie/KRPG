using KRPG.Systems.Screens.ScreenResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KRPG.Helper
{
    public static class TextFormatter
    {
        public static string[] FormatEnumName<TEnum>()
        {
            string[] names = Enum.GetNames(typeof(TEnum))
                .Select(name => Regex.Replace(name, "(?<!^)([A-Z])", " $1"))
                .ToArray();

            return names;
        }
    }
}
