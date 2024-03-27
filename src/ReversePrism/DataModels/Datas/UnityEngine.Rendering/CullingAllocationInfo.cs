using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 visibleLightsPtr                         IntPtr IL2CPP_TYPE_PTR
    // 018 visibleOffscreenVertexLightsPtr          IntPtr IL2CPP_TYPE_PTR
    // 020 visibleReflectionProbesPtr               IntPtr IL2CPP_TYPE_PTR
    // 028 VisibleLightCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C VisibleOffscreenVertexLightCount         0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 VisibleReflectionProbeCount              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CullingAllocationInfo
    {
        public int                                      VisibleLightCount                       { get; set; }
        public int                                      VisibleOffscreenVertexLightCount        { get; set; }
        public int                                      VisibleReflectionProbeCount             { get; set; }

        public static CullingAllocationInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CullingAllocationInfo();

            value.VisibleLightCount                         = GetInt32(new IntPtr(p + 0x028)); // 0270068CD900 0x28 VisibleLightCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleOffscreenVertexLightCount          = GetInt32(new IntPtr(p + 0x02C)); // 0270068CD920 0x2C VisibleOffscreenVertexLightCount ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleReflectionProbeCount               = GetInt32(new IntPtr(p + 0x030)); // 0270068CD940 0x30 VisibleReflectionProbeCount ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
