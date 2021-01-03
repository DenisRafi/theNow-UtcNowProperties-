using static System.Console;
using System.Globalization;
using System;

namespace _
{
    class _
    {
        static void Main()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE" };
            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                WriteLine("{0}:", culture.NativeName);
                WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(culture), localDate.Kind);
                WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);
            }
            ReadKey();
        }
    }
}
