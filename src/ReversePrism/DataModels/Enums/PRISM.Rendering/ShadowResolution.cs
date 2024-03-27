using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ShadowResolution
    {
        SameAsModelBuffer,
        _240p,
        _360p,
        _480p,
        _720p,
        _1080p,
        _1440p,
    }
}
