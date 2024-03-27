using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RenderDataDirtyTypes
    {
        None,
        Transform,
        ClipRectSize,
        Clipping,
        ClippingHierarchy,
        Visuals,
        VisualsHierarchy,
        VisualsOpacityId,
        Opacity,
        OpacityHierarchy,
        Color,
        AllVisuals,
    }
}
