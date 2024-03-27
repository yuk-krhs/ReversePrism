using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CultureTypes
    {
        NeutralCultures,
        SpecificCultures,
        InstalledWin32Cultures,
        AllCultures,
        UserCustomCulture,
        ReplacementCultures,
        WindowsOnlyCultures,
        FrameworkCultures,
    }
}
