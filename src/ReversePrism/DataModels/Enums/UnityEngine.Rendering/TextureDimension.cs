using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum TextureDimension
    {
        Unknown,
        None,
        Any,
        Tex2D,
        Tex3D,
        Cube,
        Tex2DArray,
        CubeArray,
    }
}
