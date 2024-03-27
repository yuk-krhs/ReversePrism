using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ShaderPropertyFlags
    {
        None,
        HideInInspector,
        PerRendererData,
        NoScaleOffset,
        Normal,
        HDR,
        Gamma,
        NonModifiableTextureData,
        MainTexture,
        MainColor,
    }
}
