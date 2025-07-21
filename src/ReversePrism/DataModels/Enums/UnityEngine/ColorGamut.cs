using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ColorGamut
    {
        sRGB,
        Rec709,
        Rec2020,
        DisplayP3,
        HDR10,
        DolbyHDR,
        P3D65G22,
    }
}
