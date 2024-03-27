using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RenderingFlag
    {
        None,
        Render2D,
        Render3D,
        MainDraw,
        Base,
        SupportDynamicBatching,
        RenderPPS,
        RenderLdrBloom,
        Common,
    }
}
