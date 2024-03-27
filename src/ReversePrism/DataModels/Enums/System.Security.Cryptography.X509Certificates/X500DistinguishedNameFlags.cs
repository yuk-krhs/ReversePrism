using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum X500DistinguishedNameFlags
    {
        None,
        Reversed,
        UseSemicolons,
        DoNotUsePlusSign,
        DoNotUseQuotes,
        UseCommas,
        UseNewLines,
        UseUTF8Encoding,
        UseT61Encoding,
        ForceUTF8Encoding,
    }
}
