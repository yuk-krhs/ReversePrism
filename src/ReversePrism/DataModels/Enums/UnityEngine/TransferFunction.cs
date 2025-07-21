using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TransferFunction
    {
        Unknown,
        sRGB,
        BT1886,
        PQ,
        Linear,
        Gamma22,
    }
}
