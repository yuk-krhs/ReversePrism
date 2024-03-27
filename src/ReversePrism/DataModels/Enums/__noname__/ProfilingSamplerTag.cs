using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum ProfilingSamplerTag
    {
        PrismRenderPipeline,
        BeginCamera,
        EndCamera,
        Begin3D,
        RestoreCamera,
        DrawGrabPass,
        DrawReservedBufferPass,
        End3D,
        OnRenderObject,
    }
}
