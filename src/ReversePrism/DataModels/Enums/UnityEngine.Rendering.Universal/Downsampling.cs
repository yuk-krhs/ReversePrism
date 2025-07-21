using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Downsampling
    {
        None,
        _2xBilinear,
        _4xBox,
        _4xBilinear,
    }
}
