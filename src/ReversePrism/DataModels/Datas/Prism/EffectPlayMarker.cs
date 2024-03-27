using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 EffectName                               000186671910 ModelPrimitiveType string string string String
    // 038 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class EffectPlayMarker
    {
        public int                                      Index                                   { get; set; }
        public string                                   EffectName                              { get; set; }
        public string                                   Value                                   { get; set; }

        public static EffectPlayMarker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EffectPlayMarker();

            value.Index                                     = GetInt32(new IntPtr(p + 0x028)); // 0270D4D9F078 0x28 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EffectName                                = GetString(new IntPtr(p + 0x030)); // 0270D4D9F098 0x30 EffectName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x038)); // 0270D4D9F0B8 0x38 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
