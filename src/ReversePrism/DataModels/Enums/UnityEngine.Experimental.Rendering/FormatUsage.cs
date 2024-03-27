using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum FormatUsage
    {
        Sample,
        Linear,
        Sparse,
        Render,
        Blend,
        GetPixels,
        SetPixels,
        SetPixels32,
        ReadPixels,
        LoadStore,
        MSAA2x,
        MSAA4x,
        MSAA8x,
        StencilSampling,
    }
}
