using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <FramePerSec>k__BackingField             int IL2CPP_TYPE_I4
    // 008 cameraRenderDataList                     List`1<CameraRenderData> IL2CPP_TYPE_GENERICINST
    // 010 DefaultScreenWidth                       ModelPrimitiveType int int int Int32
    // 014 DefaultScreenHeight                      ModelPrimitiveType int int int Int32
    public partial class RenderManager : DataModel
    {
        public int                                      DefaultScreenWidth                      { get; set; }
        public int                                      DefaultScreenHeight                     { get; set; }

        public static RenderManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderManager() { Pointer= p0 };

            value.DefaultScreenWidth                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 DefaultScreenWidth          ( ModelPrimitiveType int int int Int32 )
            value.DefaultScreenHeight                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 DefaultScreenHeight         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
