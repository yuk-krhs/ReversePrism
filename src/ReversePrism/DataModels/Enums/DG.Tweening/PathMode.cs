using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum PathMode
    {
        Ignore,
        Full3D,
        TopDown2D,
        Sidescroller2D,
    }
}
