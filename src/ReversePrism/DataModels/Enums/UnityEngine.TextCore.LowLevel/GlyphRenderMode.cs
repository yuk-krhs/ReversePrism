using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum GlyphRenderMode
    {
        SMOOTH_HINTED,
        SMOOTH,
        COLOR_HINTED,
        COLOR,
        RASTER_HINTED,
        RASTER,
        SDF,
        SDF8,
        SDF16,
        SDF32,
        SDFAA_HINTED,
        SDFAA,
    }
}
