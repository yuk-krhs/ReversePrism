using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 actionDict                               Dictionary`2<Camera, HashSet`1<Action`2<RenderTargetIdentifier, CommandBuffer>>> IL2CPP_TYPE_GENERICINST
    // 008 _enabled                                 bool IL2CPP_TYPE_BOOLEAN
    public partial class CameraCaptureBridge
    {

        public static CameraCaptureBridge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraCaptureBridge();


            return value;
        }
    }
}
