using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum GlyphLoadFlags
    {
        LOAD_DEFAULT,
        LOAD_NO_SCALE,
        LOAD_NO_HINTING,
        LOAD_RENDER,
        LOAD_NO_BITMAP,
        LOAD_FORCE_AUTOHINT,
        LOAD_MONOCHROME,
        LOAD_NO_AUTOHINT,
        LOAD_COLOR,
        LOAD_COMPUTE_METRICS,
        LOAD_BITMAP_METRICS_ONLY,
    }
}
