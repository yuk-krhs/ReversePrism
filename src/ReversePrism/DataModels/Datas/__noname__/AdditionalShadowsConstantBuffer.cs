using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _AdditionalLightsWorldToShadow           int IL2CPP_TYPE_I4
    // 004 _AdditionalShadowParams                  int IL2CPP_TYPE_I4
    // 008 _AdditionalShadowOffset0                 int IL2CPP_TYPE_I4
    // 00C _AdditionalShadowOffset1                 int IL2CPP_TYPE_I4
    // 010 AdditionalShadowFadeParams               ModelPrimitiveType int int int Int32
    // 014 AdditionalShadowmapSize                  ModelPrimitiveType int int int Int32
    public partial class AdditionalShadowsConstantBuffer : DataModel
    {
        public int                                      AdditionalShadowFadeParams              { get; set; }
        public int                                      AdditionalShadowmapSize                 { get; set; }

        public static AdditionalShadowsConstantBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdditionalShadowsConstantBuffer() { Pointer= p0 };

            value.AdditionalShadowFadeParams                = GetInt32(new IntPtr(p + 0x010)); // 0x10 AdditionalShadowFadeParams  ( ModelPrimitiveType int int int Int32 )
            value.AdditionalShadowmapSize                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 AdditionalShadowmapSize     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
