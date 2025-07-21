using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _WorldToShadow                           int IL2CPP_TYPE_I4
    // 004 _ShadowParams                            int IL2CPP_TYPE_I4
    // 008 _CascadeShadowSplitSpheres0              int IL2CPP_TYPE_I4
    // 00C _CascadeShadowSplitSpheres1              int IL2CPP_TYPE_I4
    // 010 CascadeShadowSplitSpheres2               ModelPrimitiveType int int int Int32
    // 014 CascadeShadowSplitSpheres3               ModelPrimitiveType int int int Int32
    // 018 CascadeShadowSplitSphereRadii            ModelPrimitiveType int int int Int32
    // 01C ShadowOffset0                            ModelPrimitiveType int int int Int32
    // 020 ShadowOffset1                            ModelPrimitiveType int int int Int32
    // 024 ShadowmapSize                            ModelPrimitiveType int int int Int32
    public partial class MainLightShadowConstantBuffer : DataModel
    {
        public int                                      CascadeShadowSplitSpheres2              { get; set; }
        public int                                      CascadeShadowSplitSpheres3              { get; set; }
        public int                                      CascadeShadowSplitSphereRadii           { get; set; }
        public int                                      ShadowOffset0                           { get; set; }
        public int                                      ShadowOffset1                           { get; set; }
        public int                                      ShadowmapSize                           { get; set; }

        public static MainLightShadowConstantBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainLightShadowConstantBuffer() { Pointer= p0 };

            value.CascadeShadowSplitSpheres2                = GetInt32(new IntPtr(p + 0x010)); // 0x10 CascadeShadowSplitSpheres2  ( ModelPrimitiveType int int int Int32 )
            value.CascadeShadowSplitSpheres3                = GetInt32(new IntPtr(p + 0x014)); // 0x14 CascadeShadowSplitSpheres3  ( ModelPrimitiveType int int int Int32 )
            value.CascadeShadowSplitSphereRadii             = GetInt32(new IntPtr(p + 0x018)); // 0x18 CascadeShadowSplitSphereRadii ( ModelPrimitiveType int int int Int32 )
            value.ShadowOffset0                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ShadowOffset0               ( ModelPrimitiveType int int int Int32 )
            value.ShadowOffset1                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 ShadowOffset1               ( ModelPrimitiveType int int int Int32 )
            value.ShadowmapSize                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 ShadowmapSize               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
