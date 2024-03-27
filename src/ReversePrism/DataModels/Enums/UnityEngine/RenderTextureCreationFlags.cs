using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RenderTextureCreationFlags
    {
        MipMap,
        AutoGenerateMips,
        SRGB,
        EyeTexture,
        EnableRandomWrite,
        CreatedFromScript,
        AllowVerticalFlip,
        NoResolvedColorSurface,
        DynamicallyScalable,
        BindMS,
    }
}
