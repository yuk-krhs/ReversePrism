using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VisibleLightIndex                        ModelPrimitiveType ushort ushort ushort UInt16
    // 012 LightBufferIndex                         ModelPrimitiveType ushort ushort ushort UInt16
    // 018 Light                                    ModelClassType Light Light Light Pointer
    // 000 s_CompareByCookieSize                    Func`3<LightCookieMapping, LightCookieMapping, int> IL2CPP_TYPE_GENERICINST
    // 008 s_CompareByBufferIndex                   Func`3<LightCookieMapping, LightCookieMapping, int> IL2CPP_TYPE_GENERICINST
    public partial class LightCookieMapping : DataModel
    {
        public ushort                                   VisibleLightIndex                       { get; set; }
        public ushort                                   LightBufferIndex                        { get; set; }
        public Light?                                   Light                                   { get; set; }

        public static LightCookieMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightCookieMapping() { Pointer= p0 };

            value.VisibleLightIndex                         = GetUInt16(new IntPtr(p + 0x010)); // 0x10 VisibleLightIndex           ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.LightBufferIndex                          = GetUInt16(new IntPtr(p + 0x012)); // 0x12 LightBufferIndex            ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Light                                     = GetObject<Light>(new IntPtr(p + 0x018), ReversePrism.DataModels.Light.FromPointer); // 0x18 Light                       ( ModelClassType Light Light Light Pointer )

            return value;
        }
    }
}
