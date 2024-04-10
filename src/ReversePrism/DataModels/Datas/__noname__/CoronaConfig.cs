using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 011 NonAlpha                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 OnAlphaIntensity                         000186666050 ModelPrimitiveType float float float Single
    // 018 Intensity                                000186666050 ModelPrimitiveType float float float Single
    public partial class CoronaConfig : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public bool                                     NonAlpha                                { get; set; }
        public float                                    OnAlphaIntensity                        { get; set; }
        public float                                    Intensity                               { get; set; }

        public static CoronaConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoronaConfig() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 024664EAE8B8 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NonAlpha                                  = GetBool(new IntPtr(p + 0x011)); // 024664EAE8D8 0x11 NonAlpha                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OnAlphaIntensity                          = GetSingle(new IntPtr(p + 0x014)); // 024664EAE8F8 0x14 OnAlphaIntensity            ( 000186666050 ModelPrimitiveType float float float Single )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x018)); // 024664EAE918 0x18 Intensity                   ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
