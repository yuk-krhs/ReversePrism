using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PlatformID
    {
        Win32S,
        Win32Windows,
        Win32NT,
        WinCE,
        Unix,
        Xbox,
        MacOSX,
    }
}
