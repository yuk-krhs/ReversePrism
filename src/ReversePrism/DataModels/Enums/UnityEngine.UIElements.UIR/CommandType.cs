using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CommandType
    {
        Draw,
        ImmediateCull,
        Immediate,
        PushView,
        PopView,
        PushScissor,
        PopScissor,
        PushRenderTexture,
        PopRenderTexture,
        BlitToPreviousRT,
        PushDefaultMaterial,
        PopDefaultMaterial,
    }
}
